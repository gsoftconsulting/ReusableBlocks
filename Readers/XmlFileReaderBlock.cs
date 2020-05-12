using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReusableBlocks.Readers
{
    public class XmlFileReaderBlock<T> : IReader<T> where T : class
    {
        private FilePathBuilderBlock filePathBuilder;
        static XmlSerializer xs = new XmlSerializer(typeof(T));

        public XmlFileReaderBlock(string path)
        {
            filePathBuilder = new FilePathBuilderBlock(path);
        }

        public XmlFileReaderBlock(string folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public T Read()
        {
            String filePath = filePathBuilder.Build();
            using (TextReader textReader = File.OpenText(filePath))
            {
                return xs.Deserialize(textReader) as T;
            }            
        }
    }
}
