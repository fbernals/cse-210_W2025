class JournalEntry
{
    public DateTime Date;
    public string Prompt;
    public string Response;

    public override string ToString()
    {
        return $"{Date} - Prompt: {Prompt}\nResponse: {Response}";
    }
}