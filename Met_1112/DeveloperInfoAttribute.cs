using System;
using System.Reflection;

namespace Met_1112
{

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public class DeveloperInfoAttribute : Attribute
    {
        public DeveloperInfoAttribute(string developer)
        {
            // ???
        }
    }
}
