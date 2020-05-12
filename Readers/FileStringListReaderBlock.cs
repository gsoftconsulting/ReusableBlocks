using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Readers
{
    public class FileStringListReaderBlock : IStringListReader
    {
        private IBuilder<String> filePathBuilder;
        private Encoding encoding;

        public FileStringListReaderBlock(string filePath) 
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public FileStringListReaderBlock(String folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public FileStringListReaderBlock(IBuilder<String> pathBuilder)
        {
            this.filePathBuilder = pathBuilder;
        }

        public FileStringListReaderBlock(string filePath, Encoding encoding)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
            this.encoding = encoding;
        }

        public FileStringListReaderBlock(String folder, string fileName, Encoding encoding)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
            this.encoding = encoding;
        }

        public FileStringListReaderBlock(IBuilder<String> pathBuilder, Encoding encoding)
        {
            this.filePathBuilder = pathBuilder;
            this.encoding = encoding;
        }

        public IList<String> Read()
        {            
            using (StreamReader s = GetFileStream())
            {
                IStringListReader reader = new StringListReaderBlock(s);
                return reader.Read();
            }
        }

        private StreamReader GetFileStream()
        {
            String filePath = filePathBuilder.Build();

            if (encoding == null)
                return new StreamReader(filePath);
            else
                return new StreamReader(filePath, encoding);
        }
    }
}
