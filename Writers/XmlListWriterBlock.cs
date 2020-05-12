using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReusableBlocks.Writers
{
    public class XmlListWriterBlock<T> : IListWriter<T> 
    {
        private TextWriter writer;
        static XmlSerializer xs = new XmlSerializer(typeof(List<T>));

        public XmlListWriterBlock(TextWriter writer)
        {
            this.writer = writer;
        }

        public void Write(IList<T> list)
        {            
            xs.Serialize(writer, list);
        }
    }
}
