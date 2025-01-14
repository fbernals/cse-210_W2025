using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        float average;
        int max = int.MinValue;
        int min = int.MaxValue;
        List<int> sortedNumbers = new List<int>();
        do {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
                numbers.Add(number);
            }
            
        } while (number != 0);
        
        foreach (int item in numbers){
            Console.WriteLine(item);
            sum += item;
            
            
            if (item > max){
                max = item;
            }
            
            if (item < min && item > 0){
                min = item;
            }
            
        }

        sortedNumbers = numbers.OrderBy(x => x).ToList();
        average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average:0.00}");
        Console.WriteLine($"The largest number is {max}");
        Console.WriteLine($"The smallest positive number is {min}");
        Console.WriteLine("The numbers in ascending order are: ");
        foreach (int num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
            
    }
}