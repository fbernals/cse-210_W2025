// Class to represent the scripture text
public class Scripture
{
    private List<ScriptureWord> _words = new List<ScriptureWord>();
    private ScriptureReference _reference;
    private ScriptureWord _lastHiddenWord;

    public Scripture(string reference, string text)
    {
        _reference = new ScriptureReference(reference);

        // Split the text into words and initialize the ScriptureWords
        var textWords = text.Split(' ');
        foreach (var word in textWords)
        {
            _words.Add(new ScriptureWord(word));
        }
        _lastHiddenWord = null;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        foreach (var word in _words)
        {
            if (word.GetHidden())
            {
                Console.Write(new string('_', word.GetWord().Length) + " ");
            }
            else
            {
                Console.Write(word.GetWord() + " ");
            }
        }
        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
    }

    public void HideRandomWord()
    {
        var random = new Random();
        var visibleWords = _words.Where(w => !w.GetHidden()).ToList();
        if (visibleWords.Any())
        {
            _lastHiddenWord = visibleWords[random.Next(visibleWords.Count)]; // Store last hidden word
            _lastHiddenWord.SetHidden(true);
        }
    }

    public void RevealHiddenWord()
    {
        if (_lastHiddenWord != null && _lastHiddenWord.GetHidden())
        {
            _lastHiddenWord.SetHidden(false);
            _lastHiddenWord = null; // Reset after revealing
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.GetHidden());
    }
}
