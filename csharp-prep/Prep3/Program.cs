using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
        int guessedNumber = 0;
        int tries = 1;
        string answer = "yes";
        
        while (answer == "yes"){
            Random newRandomNumber = new Random();
            int number = newRandomNumber.Next(1, 100);
            while (guessedNumber != number) {
                
                Console.Write("Enter guessed number: ");
                guessedNumber = int.Parse(Console.ReadLine());
                
                if (guessedNumber < number) {
                        Console.WriteLine("Guess higher.");
                }
                else if (guessedNumber > number) {
                    Console.WriteLine("Guess lower");
                }
                else if (guessedNumber == number) {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You took {tries} tries to guess.");
                    tries = 0;
                    Console.WriteLine("Play again?(yes/no): ");
                    answer = Console.ReadLine().ToLower();
                }
                tries++;
            
            }

        } Console.WriteLine("Thank you for playing!");
    }
}