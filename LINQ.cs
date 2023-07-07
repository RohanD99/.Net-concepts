using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using Query Syntax
            List<string> strList = new List<string>
            {
                "C#",
                "Java",
                "Angular"
            };

            Console.WriteLine("LINQ queries");
            Console.ReadLine();

            // Using Query Syntax 
            IEnumerable<string> result = from s in strList where s.Contains("Angular") select s;

            Console.WriteLine("Output of Query syntax string is :");
            PrintResults(result);

            // Using Method Syntax
            var results = strList.Where(s => s.Contains("Java"));

            Console.WriteLine("Output of Method syntax string is :");
            PrintResults(results);
        }

        // Method to print the results using IEnumerable and IEnumerator
        static void PrintResults(IEnumerable<string> results)
        {
            IEnumerator<string> enumerator = results.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                Console.ReadLine();
            }
        }
    }
}
