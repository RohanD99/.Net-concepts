using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "example.txt";

        // Write data to a file
        WriteToFile(filePath, "Hello, World!");

        // Read data from a file
        string content = ReadFromFile(filePath);
        Console.WriteLine("File Content:");
        Console.WriteLine(content);
        Console.ReadLine();
    }

    public static void WriteToFile(string filePath, string content)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(content);
        }
    }

    public static string ReadFromFile(string filePath)
    {
        string content;
        using (StreamReader reader = new StreamReader(filePath))
        {
            content = reader.ReadToEnd();
        }
        return content;
    }

}
