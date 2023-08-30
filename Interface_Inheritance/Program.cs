using System;

namespace InterfaceInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            IDownloadable newmedia = new MultimediaFile();
            newmedia.Download();

        }
    }
}
