using System.Diagnostics;

class Spinner
{
    private void Start()
    {
        Stopwatch stopwatch = new Stopwatch();
        Console.CursorVisible = false;
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < 3)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("/");
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write("-");
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write("\\");
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write("|");
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
    public void GetSpinner(){
        Start();
    }
}