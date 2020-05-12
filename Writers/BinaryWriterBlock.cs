using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Writers
{
    public class BinaryWriterBlock : IBinaryWriter
    {
        private Stream stream;

        public BinaryWriterBlock(Stream s)
        {
            if (!s.CanWrite)
                throw new ArgumentException("Stream does not support write operation!");

            this.stream = s;
        }

        public void Write(byte[] output)
        {
            stream.Write(output, 0, output.Length);
        }
    }
}
