using System;
using System.Collections.Generic;

namespace ReusableBlocks.Interfaces
{
    public interface IStringListReader : IListReader<String>
    {
        new IList<String> Read();
    }
}
