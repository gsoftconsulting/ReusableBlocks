using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Interfaces
{
    public interface IReader<T>
    {
        T Read();
    }

    public interface IReader<T1, T2>
    {
        T1 Read(T2 parameter);
    }

}
