using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ReusableBlocks.Interfaces;

namespace ReusableBlocks.Readers
{
    public class StringListReaderBlock : IStringListReader
    {
        private TextReader reader;

        public StringListReaderBlock(TextReader reader)
        {
            this.reader = reader;
        }        

        public StringListReaderBlock(StreamReader reader)
        {
            this.reader = reader;
        }

        public IList<String> Read()
        {
            List<String> list = new List<string>();

            while (reader.Peek() >= 0)
            {
                list.Add(reader.ReadLine());
            }

            return list;
        }
    }
}
