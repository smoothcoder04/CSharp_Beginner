using System;
using System.Threading.Tasks;

namespace WorkingwithParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(PrintFirst, PrintSecond, PrintThird);
            string[] filestoConvert = new string[]
            {
                "EmployeeList.docx",
                "Salaries.docx",
                "Rules.docx",
                "EmploymentContract.docx",
                "Handbook.docx",
                "FAQ.docx",
                "untitled.docx",
                "New.docx",
                "Graphs.docx",
                "EOD.docx"
            };
            string[] filesToConvertUsingForEach = new string[]
            {
                "EmployeeList.docx",
                "Salaries.docx",
                "Rules.docx",
                "EmploymentContract.docx",
                "Handbook.docx",
                "FAQ.docx",
                "untitled.docx",
                "New.docx",
                "Graphs.docx",
                "EOD.docx"
            };

            //instead of converting each file using for loop we can use Parallel 
            Parallel.For(0, filestoConvert.Length, (i) =>
            {
                Console.WriteLine($"Successfully converted file {filestoConvert[i]} to pdf");
            });

            Parallel.ForEach<string>(filesToConvertUsingForEach, (fileName) =>
            {
                Console.WriteLine($"Successfully converted the file {fileName} to PDF using ForEach.");
            });
        }

        static void PrintFirst()
        {
            Console.WriteLine("Started First");
        }

        static void PrintSecond()
        {
            Console.WriteLine("Started Second");
        }

        static void PrintThird()
        {
            Console.WriteLine("Started Third");
        }
    }
}
