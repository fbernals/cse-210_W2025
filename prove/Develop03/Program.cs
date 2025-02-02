using System;

class Program
{
    static void Main()
    {
        string reference = "Proverbs 3:5-6";
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        var scripture = new Scripture(reference, scriptureText);

        do
        {
            scripture.Display();

            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                scripture.RevealHiddenWord();
            }
            else
            {
                scripture.HideRandomWord();
            }

        } while (!scripture.AllWordsHidden());
    }
}
