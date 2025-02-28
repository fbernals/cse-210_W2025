class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            totalScore += goals[index].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(totalScore);
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points},{goal.GetStatus()}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            totalScore = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string type = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);
                
                if (type == "SimpleGoal") goals.Add(new SimpleGoal(name, points));
                else if (type == "EternalGoal") goals.Add(new EternalGoal(name, points));
                else if (type == "ChecklistGoal") goals.Add(new ChecklistGoal(name, points, 10, 500)); // Default values
            }
        }
    }
}
