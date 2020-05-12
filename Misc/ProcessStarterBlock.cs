using ReusableBlocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Misc
{
    public class ProcessStarterBlock : IStarter<String>
    {
        public void Start(String target)
        {
            if (!String.IsNullOrWhiteSpace(target))
                System.Diagnostics.Process.Start(target);
        }
    }
}
