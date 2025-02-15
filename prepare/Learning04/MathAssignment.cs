class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        GetSummary();
        Console.WriteLine($"{_textbookSection}, {_problems}");
    }

}