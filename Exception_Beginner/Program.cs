using System;

namespace ExceptionSample
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var num = new int[] { 1, 2, 3, 4 };
                Console.WriteLine(num[5]);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This block always run....");
            }
        }
    }
}