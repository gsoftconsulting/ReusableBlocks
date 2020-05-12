using ReusableBlocks.Interfaces;
using ReusableBlocks.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Readers
{
    public class FileBinaryReaderBlock : IBinaryReader
    {
        private IBuilder<String> filePathBuilder;

        public FileBinaryReaderBlock(string path) 
        {
            filePathBuilder = new FilePathBuilderBlock(path);
        }

        public FileBinaryReaderBlock(String folder, string fileName)
        {
            filePathBuilder = new FilePathBuilderBlock(folder, fileName);
        }

        public FileBinaryReaderBlock(IBuilder<String> pathBuilder)
        {
            this.filePathBuilder = pathBuilder;
        }

        public byte[] Read()
        {
            String filePath = filePathBuilder.Build();

            return File.ReadAllBytes(filePath);
        }
    }
}
