using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ReusableBlocks.Readers
{
    public class FileCsvReaderBlock<T> : IListReader<T>
    {
        static IPropertyFinder propertyFinder = new PropertyFinderBlock<T>();
        private IBuilder<String> filePathBuilder;
        private static char[] separators = { ',' };

        public FileCsvReaderBlock(string filePath)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public FileCsvReaderBlock(String folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public FileCsvReaderBlock(IBuilder<String> pathBuilder)
        {
            this.filePathBuilder = pathBuilder;
        }        

        public IList<T> Read()
        {
            List<T> list = new List<T>();
            String filePath = filePathBuilder.Build();
            
            using (TextReader reader = new StreamReader(filePath))
            {
                string line = null;
                String[] columns = null;
                bool isFirst = true;

                while ( (line = reader.ReadLine()) != null)
                {
                    if (isFirst)
                    {
                        columns = ParseHeaderRow(line);
                        isFirst = false;
                    }
                    else
                    {
                        T item = ParseDataRow(columns, line);
                        list.Add(item);
                    }
                }                                    
            }

            return list;
        }

        private static string[] ParseHeaderRow(String line)
        {
            return (line != null) ? line.Split(separators) : null;
        }

        private static T ParseDataRow(string[] columns, string line)
        {
            T item = Activator.CreateInstance<T>();
            String[] values = line.Split(separators);

            for (int i = 0; i < columns.Length; i++)
            {
                PropertyInfo matchingProperty = propertyFinder.FindProperty(columns[i], typeof(String));                    
                if (matchingProperty != null)
                {
                    try
                    {
                        Type t = GetPropertyType(matchingProperty);
                        String s = (i < values.Length)? values[i] : null;
                        Object o = Convert.ChangeType(s, t);
                        matchingProperty.SetValue(item, o, null);
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            return item;
        }

        public static Type GetPropertyType(PropertyInfo property)
        {
            // If it's not a nullable type, just pass through the parameters to Convert.ChangeType
            if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                // It's a nullable type, and not null, so that means it can be converted to its underlying type,
                // so overwrite the passed-in conversion type with this underlying type
                NullableConverter nullableConverter = new NullableConverter(property.PropertyType);
                return nullableConverter.UnderlyingType;

            } 

            return property.PropertyType;
        }
    }
}
