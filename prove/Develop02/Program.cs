using System;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("*********************************************");
        Console.WriteLine("*             Fabian Bernal                 *");
        Console.WriteLine("*                CSE210                     *");
        Console.WriteLine("*                Week 4                     *");
        Console.WriteLine("*********************************************");

        Journal journal = new Journal();
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("0. Get a random quote to help you reflect and get started.");
            Console.WriteLine("1. Write a new entry.");
            Console.WriteLine("2. Display the journal.");
            Console.WriteLine("3. Save the journal to a file.");
            Console.WriteLine("4. Load the journal from a file.");
            Console.WriteLine("5. Exit.");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    QuoteFetcher quoteFetcher = new QuoteFetcher();
                    string quote = await quoteFetcher.GetRandomQuoteAsync();
                    Console.WriteLine(quote);
                    break;

                case "1":
                    // Generate a random prompt/question
                    string[] prompts = {
                        "Write the first thing that comes to your mind.",
                        "What did you learn today?",
                        "Describe your feelings today.",
                        "What are your goals for tomorrow?",
                        "Did you have a spiritual experience?",
                        "What would you do differently tomorrow?",
                        "Free writing ticket! You may write anything that comes to your mind."
                    };
                    string randomPrompt = prompts[random.Next(prompts.Length)];

                    Console.Write($"Prompt: {randomPrompt}\nEnter your response: ");
                    string response = Console.ReadLine();

                    JournalEntry entry = new JournalEntry
                    {
                        Date = DateTime.Now,
                        Prompt = randomPrompt,
                        Response = response
                    };

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added to the journal.");
                    break;

                case "2":
                    Console.WriteLine("Journal Entries:");
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter a filename to save your journal entries: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal entries have been saved.");
                    break;

                case "4":
                    Console.Write("Enter a filename to load your journal entries: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal entries have been loaded.");
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (0-5).");
                    break;
            }
        }
    }
}
