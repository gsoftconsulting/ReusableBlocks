using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using ReusableBlocks.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ReusableBlocks
{
    public class FileCsvWriterBlock<T> : IListWriter<T>
    {
        private IBuilder<String> filePathBuilder;
        static IEnumerable<PropertyInfo> publicProperties = new PropertyInfoReaderBlock<T>().Read();

        public FileCsvWriterBlock(string filePath)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public FileCsvWriterBlock(String folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public FileCsvWriterBlock(IBuilder<String> pathBuilder)
        {
            this.filePathBuilder = pathBuilder;
        }

        public void Write(IList<T> items)
        {
            using (TextWriter writer = GetTextWriter())
            {
                WriteHeaderRow(writer);
                
                foreach (var item in items)
                {
                    WriteBodyRow(writer, item);                    
                }
            }
        }

        private TextWriter GetTextWriter()
        {
            String filePath = filePathBuilder.Build();

            String directory = Path.GetDirectoryName(filePath);
            if (directory != "" &&  !Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            return new StreamWriter(filePath);
        }

        private void WriteHeaderRow(TextWriter writer)
        {
            bool isFirst = true;

            foreach (PropertyInfo p in publicProperties)
            {
                if (isFirst)
                    isFirst = false;
                else
                    writer.Write(',');

                writer.Write(p.Name);                    
            }

            writer.Write(Environment.NewLine);
        }

        private void WriteBodyRow(TextWriter writer, T item)
        {
            bool isFirst = true;

            foreach (PropertyInfo p in publicProperties)
            {
                if (isFirst)
                    isFirst = false;                    
                else
                    writer.Write(',');
                
                WriteValue(writer, item, p);                
            }

            writer.Write(Environment.NewLine);
        }

        private void WriteValue(TextWriter writer, T item, PropertyInfo p)
        {
            Object o = p.GetValue(item);
            String value = (o != null) ? o.ToString() : null;

            if (value != null)
            {
                if (value.Contains(",") || value.Contains("\"") || value.Contains("\r") || value.Contains("\n"))
                    value = string.Format("\"{0}\"", value);
            }

            writer.Write(value);
        }

    }
}

// See https://www.pluralsight.com/guides/microsoft-net/building-a-generic-csv-writer-reader-using-reflection

/*
 /// <summary>
/// Creates the CSV from a generic list.
/// </summary>;
/// <typeparam name="T"></typeparam>;
/// <param name="list">The list.</param>;
/// <param name="csvNameWithExt">Name of CSV (w/ path) w/ file ext.</param>;
public static void CreateCSVFromGenericList<T>(List<T> list, string csvCompletePath)
{
    if (list == null || list.Count == 0) return;

    //get type from 0th member
    Type t = list[0].GetType();
    string newLine = Environment.NewLine;

    if (!Directory.Exists(Path.GetDirectoryName(csvCompletePath))) Directory.CreateDirectory(Path.GetDirectoryName(csvCompletePath));

    if (!File.Exists(csvCompletePath)) File.Create(csvCompletePath);

    using (var sw = new StreamWriter(csvCompletePath))
    {
        //make a new instance of the class name we figured out to get its props
        object o = Activator.CreateInstance(t);
        //gets all properties
        PropertyInfo[] props = o.GetType().GetProperties();

        //foreach of the properties in class above, write out properties
        //this is the header row
        sw.Write(string.Join(",", props.Select(d => d.Name).ToArray()) + newLine);

        //this acts as datarow
        foreach (T item in list)
        {
            //this acts as datacolumn
            var row = string.Join(",", props.Select(d => item.GetType()
                                                            .GetProperty(d.Name)
                                                            .GetValue(item, null)
                                                            .ToString())
                                                    .ToArray());
            sw.Write(row + newLine);

        }
    }
} 
 */


/*
 public static string ToCsv<T>(string separator, IEnumerable<T> objectlist) 
{ 
Type t = typeof(T); 
FieldInfo[] fields = t.GetFields(); 

string header = String.Join(separator, fields.Select(f => f.Name).ToArray()); 

StringBuilder csvdata = new StringBuilder(); 
csvdata.AppendLine(header); 

foreach (var o in objectlist) 
csvdata.AppendLine(ToCsvFields(separator, fields, o)); 

return csvdata.ToString(); 
} 

public static string ToCsvFields(string separator, FieldInfo[] fields, object o) 
{ 
StringBuilder linie = new StringBuilder(); 

foreach (var f in fields) 
{ 
if (linie.Length > 0) 
linie.Append(separator); 

var x = f.GetValue(o); 

if (x != null) 
linie.Append(x.ToString()); 
} 

return linie.ToString(); 
} 
 */
