class Activity
{
    private string _name;
    private string _description;
    protected int duration;
    //CountDown countdown = new CountDown();

    Spinner spinner = new Spinner();
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int seconds)
    {
        duration = seconds;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} activity. Duration: {duration} seconds.\n");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready...");
        spinner.GetSpinner();
        //countdown.StartCountdown(3);
        Console.WriteLine();
        //Thread.Sleep(3000);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        spinner.GetSpinner();
        Console.WriteLine($"\nYou've completed the {_name} activity for {duration} seconds. Great job!");
        spinner.GetSpinner();
    }
}