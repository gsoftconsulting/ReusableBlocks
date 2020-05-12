using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableBlocks.Interfaces
{
    public interface IStringWriter : IWriter<String>
    {        

    }

    public interface IStringWriter<T> : IWriter<T, String>
    {
    }

}
