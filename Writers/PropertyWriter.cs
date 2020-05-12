using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Writers
{
    public class PropertyWriter<T> : IWriter<String, Type, object>
    {
        static IEnumerable<PropertyInfo> publicProperties = new PropertyInfoReaderBlock<T>().Read();
        private T item;

        public PropertyWriter(T t)
        {
            item = t;
        }

        public void Write(String name, Type type, object value)
        {
            PropertyInfo property = publicProperties.FirstOrDefault(
                p => p.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase)
            );

            if (property != null && property.PropertyType.IsAssignableFrom(type))
            {
                property.SetValue(item, value);
            }            
        }
    }
}
