// Class to represent a single word in the scripture
public class ScriptureWord
{
    private string _word;
    private bool _isHidden;

    public ScriptureWord(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void SetHidden(bool hidden)
    {
        _isHidden = hidden;
    }

    public bool GetHidden()
    {
        return _isHidden;
    }

    public string GetWord()
    {
        return _word;
    }
}