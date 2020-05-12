using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Writers
{
    public class TextFileWriterBlock : IStringWriter
    {
        private IBuilder<String> filePathBuilder;
        private bool isAppending;
        private Encoding encoding;

        public TextFileWriterBlock(string filePath)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public TextFileWriterBlock(String folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public TextFileWriterBlock(IBuilder<String> pathBuilder)
        {
            this.filePathBuilder = pathBuilder;
        }

        public TextFileWriterBlock(string filePath, Encoding encoding)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
            this.encoding = encoding;
        }

        public TextFileWriterBlock(string filePath, Encoding encoding, Boolean isAppending)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
            this.encoding = encoding;
            this.isAppending = isAppending;
        }

        public TextFileWriterBlock(String folder, string fileName, Encoding encoding)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
            this.encoding = encoding;
        }

        public TextFileWriterBlock(IBuilder<String> pathBuilder, Encoding encoding)
        {
            this.filePathBuilder = pathBuilder;
            this.encoding = encoding;
        }

        public TextFileWriterBlock(IStringReader pathReader, Encoding encoding, Boolean isAppending)
        {
            this.filePathBuilder = new FilePathBuilderBlock(pathReader.Read());
            this.encoding = encoding;
            this.isAppending = isAppending;
        }

        public void Write(string text)
        {
            using (TextWriter s = GetTextWriter())
            {
                s.Write(text);
            }
        }

        private TextWriter GetTextWriter()
        {
            String filePath = filePathBuilder.Build();

            String directory = Path.GetDirectoryName(filePath);
            if (directory != "" && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (encoding == null)
                return new StreamWriter(filePath, isAppending);
            else
                return new StreamWriter(filePath, isAppending, encoding);
        }
    }
}
