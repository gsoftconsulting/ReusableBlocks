using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Writers
{
    public class StringListWriterBlock : IStringListWriter
    {
        private TextWriter writer;

        public StringListWriterBlock(TextWriter writer)
        {
            this.writer = writer;
        }

        public void Write(IList<string> list)
        {
            foreach (string s in list)
            {
                writer.WriteLine(s);
            }            
        }
    }
}
