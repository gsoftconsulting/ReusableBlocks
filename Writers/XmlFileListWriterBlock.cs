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
    public class FileXmlListWriterBlock<T> : IListWriter<T>
    {
        private IBuilder<String> filePathBuilder;

        public FileXmlListWriterBlock(String filePath) 
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public FileXmlListWriterBlock(String folder, String fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public FileXmlListWriterBlock(IBuilder<String> pathBuilder)
        {
            this.filePathBuilder = pathBuilder;
        }

        public void Write(IList<T> list)
        {
            using (TextWriter tw = GetTextWriter())
            {
                IListWriter<T> writer = new XmlListWriterBlock<T>(tw);
                writer.Write(list);                
            }
        }

        private TextWriter GetTextWriter()
        {
            String filePath = filePathBuilder.Build();

            String directory = Path.GetDirectoryName(filePath);
            if (directory != "" && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            return File.CreateText(filePath);
        }

    }
}
