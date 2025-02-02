// Class to represent a scripture reference
public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ScriptureReference(string reference)
    {
        // Parse the reference format (e.g., "Proverbs 3:5-6")
        var parts = reference.Split(' ');
        _book = parts[0];
        var chapterAndVerses = parts[1].Split(':');
        _chapter = int.Parse(chapterAndVerses[0]);
        var verseParts = chapterAndVerses[1].Split('-');
        _startVerse = int.Parse(verseParts[0]);
        _endVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : _startVerse;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}