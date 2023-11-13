using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // We execute a potentially long-running method in the background
            // We do not need the result yet
            Task<int> task = SquareAsync(5439);

            Console.WriteLine("The Main() method continues to run.");

            // When we need the result of the calculation, we block the current thread and wait for it
            task.Wait();
            int result = task.Result;
            Console.WriteLine($"Result: {result}.");
        }

        // The method will return an integer value
        static async Task<int> SquareAsync(int n)
        {

            var task = Task.Run(() => { return n * n; });

            Console.WriteLine("Calculation started...");

            // The await statement waits for the result of the running task
            int result = await task;

            // We just return an integer
            return result;
        }
    }
}