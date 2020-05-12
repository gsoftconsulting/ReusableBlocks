using ReusableBlocks.Extensions;
using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Misc
{
    public class SHA256Block : IBuilder<String, String>
    {
        public string Build(string input)
        {
            byte[] inputBytes = Encoding.Default.GetBytes(input);
            using (SHA256 hasher = new SHA256Managed())
            {
                byte[] bytes = hasher.ComputeHash(inputBytes);
                return bytes.BytesToString();
            }
        }
    }
}
