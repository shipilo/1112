using System;

namespace Met_1112
{
    class BuildingInfoAttribute : Attribute
    {
        public string Developer;
        public string Organization;

        public BuildingInfoAttribute(string developer, string organization)
        {
            Developer = developer;
            Organization = organization;
        }
    }
}
