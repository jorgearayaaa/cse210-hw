using System;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int userScore = 0;

    static void Main()
    {
        LoadGoals();

        while (true)
        {
            DisplayMenu();
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine($"You have {userScore} points\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create a New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void CreateGoal()
    {
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        int typeChoice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal newGoal = null;

        switch (typeChoice)
        {
            case 1:
                newGoal = new SimpleGoal
                {
                    Name = name,
                    Description = description,
                    Points = points
                };
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        if (newGoal != null)
        {
            goals.Add(newGoal);
            Console.WriteLine("Goal created!");
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("\nList of Goals:");

        foreach (Goal goal in goals)
        {
            string status = goal.IsCompleted ? "Completed" : "Not Completed";
            Console.WriteLine($"{goal.Name} - {goal.Description} - Status: {status}");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"Progress: {checklistGoal.TimesCompleted}/{checklistGoal.RequiredTimes}");
            }
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Enter the name of the goal you completed:");
        string goalName = Console.ReadLine();

        Goal goal = goals.Find(g => g.Name == goalName);

        if (goal != null)
        {
            goal.MarkCompleted();
            userScore += goal.Points;
            Console.WriteLine($"Event recorded! You gained {goal.Points} points.");
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.IsCompleted}");

                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.RequiredTimes},{checklistGoal.TimesCompleted}");
                }
            }

            writer.WriteLine(userScore);
        }
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 5)
                    {
                        Goal goal;
                        switch (parts[0])
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal();
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal();
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal();
                                break;
                            default:
                                continue;
                        }

                        goal.Name = parts[1];
                        goal.Description = parts[2];
                        goal.Points = Convert.ToInt32(parts[3]);
                        goal.IsCompleted = Convert.ToBoolean(parts[4]);

                        if (goal is ChecklistGoal checklistGoal && parts.Length >= 7)
                        {
                            checklistGoal.RequiredTimes = Convert.ToInt32(parts[5]);
                            checklistGoal.TimesCompleted = Convert.ToInt32(parts[6]);
                        }

                        goals.Add(goal);
                    }
                }

                if (int.TryParse(reader.ReadLine(), out int score))
                {
                    userScore = score;
                }
            }
        }
    }
}
