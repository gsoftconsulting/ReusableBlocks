using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Interfaces
{
    public class PropertyFinderBlock<T> : IPropertyFinder
    {
        static IEnumerable<PropertyInfo> publicProperties = new PropertyInfoReaderBlock<T>().Read();

        public PropertyInfo FindProperty(String name, Type t)
        {
            PropertyInfo property = publicProperties.FirstOrDefault(
                p => p.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase)
            );

            if (property != null && property.PropertyType.IsAssignableFrom(t))
            {
                return property;
            }

            return null;
        }
    }
}
