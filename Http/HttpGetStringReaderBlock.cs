using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Net
{
    public class HttpGetStringReaderBlock : IStringReader<String>
    {
        private ICredentials credentials;
        private String accept;
        private WebClient webClient;

        public HttpGetStringReaderBlock()
        {
        }

        public HttpGetStringReaderBlock(ICredentials credentials)
        {
            this.credentials = credentials;
        }

        public HttpGetStringReaderBlock(String accept)
        {
            this.accept = accept;
        }

        public HttpGetStringReaderBlock(ICredentials credentials, String accept)
        {
            this.credentials = credentials;
            this.accept = accept;
        }

        public string Read(String url)
        {
            using (webClient = new WebClient())
            {
                if (credentials != null)
                    webClient.Credentials = credentials;
                else
                    webClient.Credentials = CredentialCache.DefaultCredentials;

                if (accept != null)
                    webClient.Headers[HttpRequestHeader.Accept] = accept;

                return webClient.DownloadString(url);
            }

        }

        public string Read()
        {
            throw new NotImplementedException();
        }
    }
}
