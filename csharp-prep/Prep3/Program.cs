using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to guess: ");
        int numberToGuess = int.Parse(Console.ReadLine());
        int guessedNumber = 0;
        
        while (guessedNumber != numberToGuess) {
            Console.Write("Enter guessed number: ");
            guessedNumber = int.Parse(Console.ReadLine());
            
            if (guessedNumber < numberToGuess) {
                    Console.WriteLine("Guess higher.");
            }
            else if (guessedNumber > numberToGuess) {
                Console.WriteLine("Guess lower");
            }
            else if (guessedNumber == numberToGuess) {
                Console.WriteLine("You guessed it!");
            }
        
    } 
    }
}