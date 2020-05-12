using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Readers
{
    public class BinaryStreamReaderBlock : IBinaryReader
    {
        private Stream stream;

        public BinaryStreamReaderBlock(Stream s)
        {
            if (!s.CanRead)
                throw new ArgumentException("Stream does not support read operation!");

            this.stream = s;
        }

        public byte[] Read()
        {
            byte[] buffer = new byte[stream.Length];
            int count = buffer.Length;
            stream.Read(buffer, 0, count);

            return buffer;
        }
    }
}
