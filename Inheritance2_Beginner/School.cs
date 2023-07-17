using System;

namespace Inheritance
{
    public class School : EducationalOrg
    {
        //Since the EducationalOrg didn't have default constructor, the 
        //public School(string name) : base(name)
        public School(string name)
        {
            Name = name;
            Console.WriteLine("School Constructor");

        }
    }
}