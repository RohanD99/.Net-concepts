using System;
using System.Collections.Generic;
using ExtensionMethods;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections:");
            List<int> cities = new List<int>();
            IDictionary<int,string> names =  new Dictionary<int,string>();

            cities.Add(1);
            cities.Add(2);
            cities.Add(5);
            Console.WriteLine("List:" +cities.Count);
            Console.ReadLine();

            names.Add(1, "rohan");
            names.Add(2, "rohan");
            names.Add(3, "rohan");
            Console.WriteLine("Dictionary:" +names.Count);
            Console.ReadLine();

            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };
            for (int i = 0; i < numberNames.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);
            }
            Console.ReadLine();

            int y = 10;

            bool result = y.IsGreaterThan(100);

            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
