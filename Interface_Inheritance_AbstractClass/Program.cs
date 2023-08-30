using System;

namespace InterfaceInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            //IDownloadable newmedia = new MultimediaFile();
            //newmedia.Download();

            var userfile = new UserFile();
            userfile.Download();

            var mediafile = new MultimediaFile();
            mediafile.Download();

        }
    }
}
