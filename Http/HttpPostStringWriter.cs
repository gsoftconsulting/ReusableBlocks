using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Net
{
    public class HttpPostStringWriter : IStringWriter<String>
    {
        private string contentType = "application/x-www-form-urlencoded";
        private string accept;
        private ICredentials credentials;

        public HttpPostStringWriter(ICredentials credentials)
        {
            this.credentials = credentials;
        }

        public HttpPostStringWriter(String accept)
        {
            this.accept = accept;
        }

        public HttpPostStringWriter(ICredentials credentials, String accept)
        {
            this.credentials = credentials;
            this.accept = accept;
        }


        public void Write(string url, string content)
        {
            HttpWebRequest request = CreateRequest(url);
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] bytes = encoding.GetBytes(content);
            request.ContentLength = bytes.Length;
            request.AllowWriteStreamBuffering = true;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }

        private HttpWebRequest CreateRequest(String url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            request.ContentType = contentType;

            if (credentials != null)
                request.Credentials = credentials;
            else
                request.Credentials = CredentialCache.DefaultCredentials;

            if (accept != null)
                request.Accept = accept;
            return request;
        }

    }
}
