using System;
using System.Reflection;

namespace ReusableBlocks.Interfaces
{
    public interface IPropertyFinder
    {
        PropertyInfo FindProperty(String name, Type t);
    }
}