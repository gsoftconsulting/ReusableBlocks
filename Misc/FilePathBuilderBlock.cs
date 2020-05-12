using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Misc
{
    public class FilePathBuilderBlock : IBuilder<String>
    {
        private String filePath;
        private String folder;

        public FilePathBuilderBlock(string filePath)
        {
            this.filePath = filePath;
        }

        public FilePathBuilderBlock(String folder, string fileName)
        {
            this.folder = folder;
            this.filePath = fileName;
        }        

        public string Build()
        {
            return (folder != null) ? Path.Combine(folder, filePath) : filePath;
        }
    }
}
