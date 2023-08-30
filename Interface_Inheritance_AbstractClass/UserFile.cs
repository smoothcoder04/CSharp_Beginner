using System;

namespace InterfaceInheritance
{
    //public abstract class UserFile : IDownloadable
    public class UserFile : IDownloadable
    {
        //leave the base class without method implementation
        public virtual void Download()
        {
            Console.WriteLine("Downloading the User file.....");
        }
    }
}