using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        f1.SetNumerator(3);
        f1.SetDenominator(4);
        Fraction f2 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
    }
}