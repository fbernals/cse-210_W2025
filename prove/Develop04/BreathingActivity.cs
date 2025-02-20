using System.Diagnostics;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    CountDown countdown = new CountDown();
    Stopwatch stopwatch = new Stopwatch();    
    
    public void StartBreathing()
    {
        StartActivity();
        Console.WriteLine("Let's begin breathing:");
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("\nBreathe in..."); 
            countdown.StartCountdown(4);
            Console.Write("\nBreathe out..."); 
            countdown.StartCountdown(6);
            Console.WriteLine("");
        }
        stopwatch.Stop();
        EndActivity();
    }
}