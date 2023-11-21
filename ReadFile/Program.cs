using System;
using System.IO;
using System.Text;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var filestream = new FileStream("Readmefile.txt", FileMode.Open);

            //place the sequence of bytes opened
            byte[] byteSequence = new byte[filestream.Length];
            filestream.Read(byteSequence, 0, byteSequence.Length);

            //now we have a sequence of bytes. To see it as a text we need to decode the yte sequence
            string text = Encoding.UTF8.GetString(byteSequence);

            Console.WriteLine(text);

        }
    }
}