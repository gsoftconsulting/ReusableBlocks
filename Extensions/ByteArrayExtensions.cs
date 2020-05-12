using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Extensions
{
    public static class ByteArrayExtensions
    {
        public static string BytesToString(this Byte[] bytes)
        {
            StringBuilder builder = new StringBuilder(bytes.Length);

            // Loop through each byte of the data and format each one as a hexadecimal string.
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
