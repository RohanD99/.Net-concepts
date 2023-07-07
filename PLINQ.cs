using System;
using System.Linq;

namespace PLINQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 10).ToArray();

            Console.WriteLine("PLINQ Example");
            Console.WriteLine();

            // Basic PLINQ Example
            Console.WriteLine("Basic PLINQ Example:");
            var basicResult = numbers.AsParallel()
                .Where(x => x % 2 == 0)
                .Select(x => x * x);

            foreach (var item in basicResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
