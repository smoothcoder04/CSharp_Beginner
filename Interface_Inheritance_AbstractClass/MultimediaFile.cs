using System;

namespace InterfaceInheritance
{
    public class MultimediaFile : UserFile
    {
        //UserFile is the abstract base class that doesn't have the method implementation. Simply inherit the base abstract class
        public override void Download()
        {
            Console.WriteLine("This is the doanload method called from MultimediaFile class that inherited Abstract class");
        }
    }
}