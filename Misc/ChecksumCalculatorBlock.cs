using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Misc
{
    public class ChecksumCalculatorBlock : ICalculator<String, int>
    {
        public int Caclulate(string text = null)
        {
            int checksum = 0;

            if (!String.IsNullOrEmpty(text))
            {
                checksum = text.Sum(c => c - '0');
            }

            return checksum;
        }
    }
}
