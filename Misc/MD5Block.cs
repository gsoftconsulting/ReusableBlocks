using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusableBlocks.Extensions;
using ReusableBlocks.Interfaces;
using System.Security.Cryptography;


namespace ReusableBlocks.Misc
{
    public class MD5Block : IBuilder<String, String>
    {
        public string Build(String input)
        {
            byte[] inputBytes = Encoding.Default.GetBytes(input);
            using (MD5 hasher = MD5.Create())
            {
                byte[] bytes = hasher.ComputeHash(inputBytes);
                return bytes.BytesToString();
            }
        }
    }
}
