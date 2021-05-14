using System;
using System.IO;

namespace FileSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var files = Directory.GetFiles("/Users/mawhinneym/Documents/Composer", "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);
        }
    }
}
