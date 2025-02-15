class WrittingAssignment : Assignment{
    private string _title;

    public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic){
        _title = title;
    }

    public void GetHomeworkList(){
        GetSummary();
        Console.WriteLine($"{_title}");
    }
}