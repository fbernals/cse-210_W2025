using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Fabian Bernal", "Math", "Chapter 3", "1-10");
        WrittingAssignment writtingAssignment = new WrittingAssignment("Samuel Smith", "Writting", "The Best Story Ever");
        mathAssignment.GetHomeworkList();
        writtingAssignment.GetHomeworkList();
    }
}