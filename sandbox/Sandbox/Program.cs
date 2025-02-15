using System;
using System.Collections.Generic;

public class Program
{
    public static void Test1()
    {
        List<String> values = new List<String> {"Foo", "Bar", "Baz", "Boom", "Pow"};
        List<String> values2 = values; // Copies the reference
        values2[0] = "Foo2";
        values2[1] = "Bar2";

        foreach (String item in values)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        foreach (String item in values2)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    public static void Test2()
    {
        List<String> values = new List<String> {"Foo", "Bar", "Baz", "Boom", "Pow"};
        List<String> values2 = new List<String>();
        values2.AddRange(values); // Copies the entries
        values2[0] = "Foo2";
        values2[1] = "Bar2";

        foreach (String item in values)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        foreach (String item in values2)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Test1:");
        Test1();
        Console.WriteLine("\nTest2:");
        Test2();
    }
}