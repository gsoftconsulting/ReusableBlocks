using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Writers
{
    public class ExcelListWriter<T> : IListWriter<T>
    {
        private string filePath;

        public ExcelListWriter(string path)
        {
            filePath = path;
        }

        public void Write(IList<T> item)
        {
            throw new NotImplementedException();
        }
    }
}
