using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Writers
{
    public class StringWriterBlock : IStringWriter
    {
        private TextWriter writer;

        public StringWriterBlock(TextWriter writer)
        {
            this.writer = writer;
        }

        public void Write(string s)
        {
            writer.Write(s);
        }
    }
}
