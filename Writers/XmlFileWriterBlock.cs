using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReusableBlocks.Writers
{
    public class XmlFileWriterBlock<T> : IWriter<T>
    {
        private IBuilder<String> filePathBuilder;
        static XmlSerializer xs = new XmlSerializer(typeof(T));

        public XmlFileWriterBlock(string path)
        {
            filePathBuilder = new FilePathBuilderBlock(path);
        }

        public XmlFileWriterBlock(string folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public void Write(T item)
        {
            using (TextWriter tw = GetTextWriter())
            {
                xs.Serialize(tw, item);
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
