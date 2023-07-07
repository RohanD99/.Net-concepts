using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Multicast Delegate Example
        CalculationDelegate calculationDelegate = AddNumbers;
        calculationDelegate += SubtractNumbers;
        calculationDelegate += MultiplyNumbers;

        Console.WriteLine("Multicast Delegate Example:");
        calculationDelegate(5, 3);

        Console.WriteLine();

        // Func Delegate Example
        Func<int, int, bool> isGreaterThanFunc = IsGreaterThan;
        bool result = isGreaterThanFunc(10, 5);

        Console.WriteLine("Func Delegate Example:");
        Console.WriteLine($"IsGreaterThan: {result}");

        Console.WriteLine();

        // Action Delegate Example
        Action<string> printMessageAction = PrintMessage;
        printMessageAction("Hello, World!");

        Console.WriteLine();

        // Predicate Delegate Example
        Predicate<string> isLongStringPredicate = IsLongString;
        bool isLong = isLongStringPredicate("This is a long string.");

        Console.WriteLine("Predicate Delegate Example:");
        Console.WriteLine($"IsLongString: {isLong}");
        Console.ReadLine(); 
    }

    // Multicast Delegate Methods
    public delegate void CalculationDelegate(int a, int b);
    public static void AddNumbers(int a, int b)
    {
        Console.WriteLine($"Addition: {a + b}");
    }
    public static void SubtractNumbers(int a, int b)
    {
        Console.WriteLine($"Subtraction: {a - b}");
    }
    public static void MultiplyNumbers(int a, int b)
    {
        Console.WriteLine($"Multiplication: {a * b}");
    }

    // Func Delegate Method
    public static bool IsGreaterThan(int a, int b)
    {
        return a > b;
    }

    // Action Delegate Method
    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    // Predicate Delegate Method
    public static bool IsLongString(string str)
    {
        return str.Length > 10;
    }
}
