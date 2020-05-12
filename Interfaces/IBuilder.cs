using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Interfaces
{
    public interface IBuilder<T>
    {
        T Build();
    }

    public interface IBuilder<T1, T2>
    {
        T1 Build(T2 parameter);
    }

}
