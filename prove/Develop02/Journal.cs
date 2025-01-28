class Journal
{
    private List<JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = File.CreateText(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        try
        {
            using (StreamReader reader = File.OpenText(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string dateLine = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(dateLine)) continue;

                    string responseLine = reader.ReadLine();

                    try
                    {
                        string[] dateAndPrompt = dateLine.Split(" - Prompt: ");
                        string date = dateAndPrompt[0].Trim();
                        string prompt = dateAndPrompt.Length > 1 ? dateAndPrompt[1].Trim() : string.Empty;

                        string response = responseLine.Replace("Response: ", "").Trim();

                        JournalEntry entry = new JournalEntry
                        {
                            Date = DateTime.Parse(date),
                            Prompt = prompt,
                            Response = response
                        };
                        _entries.Add(entry);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error parsing entry: {ex.Message}");
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}
