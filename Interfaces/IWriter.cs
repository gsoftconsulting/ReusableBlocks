using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Interfaces
{
    public interface IWriter<T>
    {
        void Write(T item);
    }

    public interface IWriter<T1, T2>
    {
        void Write(T1 parameter1, T2 parameter2);
    }

    public interface IWriter<T1, T2, T3>
    {
        void Write(T1 parameter1, T2 parameter2, T3 parameter3);
    }

}
