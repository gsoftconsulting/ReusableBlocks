using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Interfaces
{
    public interface ICalculator<TInput, TOutput>
    {
        TOutput Caclulate(TInput parameter = default(TInput));
    }
}
