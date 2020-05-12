using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using ReusableBlocks.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Writers
{
    public class FileBinaryWriterBlock : IBinaryWriter
    {
        private IBuilder<String> filePathBuilder;

        public FileBinaryWriterBlock(String filePath)
        {
            filePathBuilder = new FilePathBuilderBlock(filePath);
        }

        public FileBinaryWriterBlock(String folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public FileBinaryWriterBlock(IBuilder<String> pathBuilder)
        {
            this.filePathBuilder = pathBuilder;
        }

        public void Write(byte[] output)
        {
            String filePath = filePathBuilder.Build();

            String directory = Path.GetDirectoryName(filePath);
            if (directory != "" && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllBytes(filePath, output);
        }
    }
}
