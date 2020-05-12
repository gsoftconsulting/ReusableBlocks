using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ReusableBlocks.Readers
{
    public class XmlListReaderBlock<T> : IListReader<T> 
    {
        private string xml;
        private IStringReader stringReader;
        private TextReader textReader;
        private XmlReader xmlReader;                        
        static XmlSerializer xs = new XmlSerializer(typeof(List<T>));

        public XmlListReaderBlock(String xml)
        {
            this.xml = xml;
        }

        public XmlListReaderBlock(IStringReader reader)
        {
            this.stringReader = reader;
        }                

        public XmlListReaderBlock(TextReader reader)
        {
            this.textReader = reader;
        }

        public XmlListReaderBlock(XmlReader reader)
        {
            this.xmlReader = reader;
        }

        public IList<T> Read()
        {
            if(xmlReader != null)
                return xs.Deserialize(xmlReader) as IList<T>;

            if (textReader != null)
                return xs.Deserialize(textReader) as List<T>;

            if (stringReader != null)
                xml = stringReader.Read();

            using (StringReader r = new StringReader(xml))
                return xs.Deserialize(r) as IList<T>;
        }
    }
}
