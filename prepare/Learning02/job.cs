public class Job{
    public string _company, _jobTitle;
    public int _startYear, _endYear;

    public void Display(){
        Console.WriteLine($"{_company}, as {_jobTitle} from {_startYear} to {_endYear}.");
    }
}