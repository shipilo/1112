using System;

namespace Met_1112
{
    public class DeveloperInfoAttribute : Attribute
    {
        public string Developer;
        public string DateOfRelease;

        public DeveloperInfoAttribute(string developer, string dateOfRelease)
        {
            Developer = developer;
            DateOfRelease = dateOfRelease;
        }
    }
}
