class CountDown
{
    public void StartCountdown(int initialValue)
    {
        for (int i = initialValue; i >= 0; i--)
        {
            Console.SetCursorPosition(13, Console.CursorTop);
            Console.Write(" " + i);
            System.Threading.Thread.Sleep(1000); // Sleep for 1 second
        }
        

    }
    


}