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
    public class TextFileReaderBlock : IStringReader
    {
        private IBuilder<String> filePathBuilder;
        private Encoding encoding;

        public TextFileReaderBlock(string filePath) 
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public TextFileReaderBlock(String folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public TextFileReaderBlock(IBuilder<String> pathReader)
        {
            this.filePathBuilder = pathReader;
        }

        public TextFileReaderBlock(string filePath, Encoding encoding)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
            this.encoding = encoding;
        }

        public TextFileReaderBlock(String folder, string fileName, Encoding encoding)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
            this.encoding = encoding;
        }

        public TextFileReaderBlock(IBuilder<String> pathReader, Encoding encoding)
        {
            this.filePathBuilder = pathReader;
            this.encoding = encoding;
        }

        public string Read()
        {            
            using (StreamReader s = GetStreamReader())
            {
                IStringReader reader = new StringReaderBlock(s);
                return reader.Read();
            }
        }

        private StreamReader GetStreamReader()
        {
            String filePath = filePathBuilder.Build();

            if (encoding == null)
                return new StreamReader(filePath);
            else
                return new StreamReader(filePath, encoding);
        }
    }
}
