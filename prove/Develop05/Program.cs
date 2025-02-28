using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add Goal\n2. Record Event\n3. Show Goals\n4. Show Score\n5. Save\n6. Load\n7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist): ");
                    int type = int.Parse(Console.ReadLine());
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == 1) manager.AddGoal(new SimpleGoal(name, points));
                    else if (type == 2) manager.AddGoal(new EternalGoal(name, points));
                    else
                    {
                        Console.Write("Enter target count: ");
                        int count = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, points, count, bonus));
                    }
                    break;

                case "2":
                    manager.DisplayGoals();
                    Console.Write("Enter goal number: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalEvent(goalIndex);
                    break;
                
                case "3":
                    manager.DisplayGoals();
                    break;
                
                case "4":
                    manager.DisplayScore();
                    break;
                
                case "5":
                    manager.SaveGoals("goals.txt");
                    break;
                
                case "6":
                    manager.LoadGoals("goals.txt");
                    break;
                
                case "7":
                    running = false;
                    break;
            }
        }
    }
}