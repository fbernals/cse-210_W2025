using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome (){
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUser(){
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber(){
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number){
            return number * number;
        }

        static string DisplayResult(string name, int number){
            return $"Brother {name}, the square of your number is {number}.";
        }

        DisplayWelcome();
        string name = PromptUser();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        Console.WriteLine(DisplayResult(name, squaredNumber));

    }
}