using System;
using System.Threading;


class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the mindfulness activities program!");
        
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
                break;

            Console.Write("Enter the duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());

            Activity currentActivity = null;

            switch (choice)
            {
                case 1:
                    currentActivity = new BreathingActivity();
                    break;
                case 2:
                    currentActivity = new ReflectionActivity();
                    break;
                case 3:
                    currentActivity = new ListingActivity();
                    break;
            }

            if (currentActivity != null)
            {
                currentActivity.SetDuration(duration);

                if (currentActivity is BreathingActivity)
                    ((BreathingActivity)currentActivity).StartBreathing();
                else if (currentActivity is ReflectionActivity)
                    ((ReflectionActivity)currentActivity).StartReflection();
                else if (currentActivity is ListingActivity)
                    ((ListingActivity)currentActivity).StartListing();
            }
        }
    }
}