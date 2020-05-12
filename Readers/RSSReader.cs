using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReusableBlocks.Readers
{
    public class RSSReader : IListReader<RSSChanel>
    {
        private String Url;

        public RSSReader(String url)
        {
            Url = url;
        }

        public IList<RSSChanel> Read()
        {
            XDocument xdoc = XDocument.Load(Url);
            var query = from rssFeed in xdoc.Descendants("channel")
                        select new RSSChanel
                        {
                            Title = rssFeed.Element("title").Value,
                            Description = rssFeed.Element("description").Value,
                            Link = rssFeed.Element("link").Value
                        };

            return query.ToList();
        }
    }

    public class RSSChanel
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public String Link { get; set; }
    }
}
