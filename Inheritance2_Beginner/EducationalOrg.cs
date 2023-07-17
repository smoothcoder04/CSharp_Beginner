using System;

namespace Inheritance
{
    public class EducationalOrg
    {
        public string Name { get; internal set; }

        public EducationalOrg()
        {

        }
        public EducationalOrg(string name)
        {
            Console.WriteLine("EducationalOrg constructor");
            this.Name = name;
        }

    }
}