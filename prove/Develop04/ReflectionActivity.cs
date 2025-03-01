using System.Diagnostics;

class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.\n",
        "Think of a time when you did something really difficult.\n",
        "Think of a time when you helped someone in need.\n",
        "Think of a time when you did something truly selfless.\n",
        "Think of a time when you were really brave.\n"
    };

    private string[] _questions = {
        "\nWhy was this experience meaningful to you? ",
        "\nWhat have you learned from this? "
        // Add more questions here
    };

    public ReflectionActivity() : base("Reflection", "Welcome to the reflecting activity. \nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void StartReflection()
    {
        Console.Clear();
        CountDown countdown = new CountDown();
        Stopwatch stopwatch = new Stopwatch();
        Spinner spinner = new Spinner();
        StartActivity();
        
        Console.WriteLine("Let's reflect: ");
        Random random = new Random();
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            string prompt = _prompts[random.Next(_prompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine("When you have something in mind press any key to continue. \n");
            Console.ReadKey();
            Console.WriteLine("Now, ponder each of the following questions as they relate to your experience. ");
            Console.Write("Begin in: ");
            countdown.StartCountdown(3);
            Console.WriteLine("");

            foreach (var question in _questions)
            {
                Console.Write($"{question}\n");
                spinner.GetSpinner();
            }
            
        }
        stopwatch.Stop();
        EndActivity();
    }
}