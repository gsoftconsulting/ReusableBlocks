using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReusableBlocks.Readers
{
    public class XmlFileListReaderBlock<T> : IListReader<T> 
    {
        private IBuilder<String> filePathBuilder;
        
        public XmlFileListReaderBlock(String filePath)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public XmlFileListReaderBlock(String folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public XmlFileListReaderBlock(IBuilder<String> pathReader)
        {
            this.filePathBuilder = pathReader;
        }

        public IList<T> Read()
        {
            String filePath = filePathBuilder.Build();
            using (TextReader reader = File.OpenText(filePath))
            {
                IListReader<T> r = new XmlListReaderBlock<T>(reader);
                return r.Read();
            }
        }

    }
}
