using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Interfaces
{
    public class PropertyInfoReaderBlock<T> : IReader<IEnumerable<PropertyInfo>>
    {
        public IEnumerable<PropertyInfo> Read()
        {
            return typeof(T).GetProperties().
                Where(p => p.CanRead
                   && p.MemberType == MemberTypes.Property
                   && p.PropertyType.Namespace == "System"
                   && !p.PropertyType.IsArray);
        }
    }
}
