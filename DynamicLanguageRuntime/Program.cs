using System;

namespace DynamicLanguageRuntime
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic course = new Course()
            {
                Title = ".NET Fundamentals"
            };
            course.Duration = 8;
            Console.WriteLine($"Duration property type: {course.Duration.GetType()}, value: {course.Duration}");

            //change course duration type to string
            course.Duration = "8 Weeks";

            Console.WriteLine("After type change...");
            Console.WriteLine($"Duration property type: {course.Duration.GetType()}, value: {course.Duration}");

            //Duration has dynamic return type
            dynamic duration = course.GetCourseDuration("string");
            Console.WriteLine($"Type: {duration.GetType()}, value: {duration}");

            duration = course.GetCourseDuration("int");
            Console.WriteLine($"Type: {duration.GetType()}, value: {duration}");
        }
    }
}