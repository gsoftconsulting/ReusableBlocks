using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Misc
{
    public class AssemblyInfoBlock : IListReader<String>
    {
        private Assembly assembly;

        public AssemblyInfoBlock(Assembly assembly)
        {
            this.assembly = assembly;
        }

        public AssemblyInfoBlock(String filePath)
        {
            String absolutePath = Path.GetFullPath(filePath);
            this.assembly = Assembly.LoadFile(absolutePath);
        }

        public IList<String> Read()
        {            
            List<String> list = new List<string>();
            AssemblyName name = assembly.GetName();
            AssemblyTitleAttribute ta = assembly.GetCustomAttribute(typeof(AssemblyTitleAttribute)) as AssemblyTitleAttribute;            

            list.Add("Title  : " + ta.Title);
            list.Add("Name   : " + name.Name);
            list.Add("Version: " + name.Version.ToString());

            return list;
        }
    }
}
