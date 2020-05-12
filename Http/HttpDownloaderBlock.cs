using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ReusableBlocks.Net
{
    public class FileDownloaderBlock : IDownloader
    {
        private IBuilder<String> filePathBuilder;
        private WebClient webClient;
        private ICredentials credentials;

        public FileDownloaderBlock(String filePath)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public FileDownloaderBlock(String folder, String fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public FileDownloaderBlock(IBuilder<String> pathBuilder)
        {
            this.filePathBuilder = pathBuilder;
        }

        public FileDownloaderBlock(String filePath, ICredentials credentials)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
            this.credentials = credentials;
        }

        public FileDownloaderBlock(String folder, String fileName, ICredentials credentials)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
            this.credentials = credentials;
        }

        public void Download(string url)
        {
            String filePath = filePathBuilder.Build();

            String directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            using (webClient = new WebClient())
            {
                if (this.credentials != null)
                    webClient.Credentials = this.credentials;
                else
                    webClient.Credentials = CredentialCache.DefaultCredentials;

                webClient.DownloadFile(url, filePath);
            }
        }

    }
}
