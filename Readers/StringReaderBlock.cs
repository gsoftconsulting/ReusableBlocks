using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ReusableBlocks.Interfaces;

namespace ReusableBlocks.Readers
{
    public class StringReaderBlock : IStringReader, IStringLineReader
    {
        private TextReader reader;

        public StringReaderBlock(TextReader reader)
        {
            this.reader = reader;
        }        

        public StringReaderBlock(StreamReader reader)
        {
            this.reader = reader;
        }

        public string Read()
        {
            if (reader.Peek() == -1)
                return null;

            return reader.ReadToEnd();                                    
        }

        public string ReadLine()
        {
            if (reader.Peek() == -1)
                return null;

            return reader.ReadLine();
        }

    }
}
