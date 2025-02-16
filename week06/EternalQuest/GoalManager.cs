using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    private int level = 1;
    private string filePath = "Data/goals.txt"; // Using .txt instead of JSON

    public int Score => score;
    public int Level => level;

    public void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(score);
                writer.WriteLine(level);
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("📂 Goals successfully saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠ Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        if (!File.Exists(filePath)) return;

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            score = int.Parse(lines[0]);
            level = int.Parse(lines[1]);

            for (int i = 2; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "Simple")
                    goals.Add(new SimpleGoal(name, description, points));
                else if (type == "Eternal")
                    goals.Add(new EternalGoal(name, description, points));
                else if (type == "Checklist")
                {
                    int target = int.Parse(parts[4]);
                    int completed = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    while (goal.IsComplete() != (completed >= target))
                        goal.RecordEvent();
                    goals.Add(goal);
                }
            }

            Console.WriteLine("✅ Goals successfully loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠ Error loading goals: {ex.Message}");
        }
    }

    public void ListGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("\n⚠ No goals available.");
            return;
        }

        Console.WriteLine("\n📋 Goals List:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        try
        {
            Console.WriteLine("\n📌 Create a New Goal");
            Console.Write("Goal Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Points when completed: ");
            int points = int.Parse(Console.ReadLine());

            Console.WriteLine("Goal Type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
            Console.Write("Select goal type: ");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    goals.Add(new SimpleGoal(name, description, points));
                    break;
                case 2:
                    goals.Add(new EternalGoal(name, description, points));
                    break;
                case 3:
                    Console.Write("Number of times required: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points upon completion: ");
                    int bonus = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("❌ Invalid option.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠ Error creating goal: {ex.Message}");
        }
    }

    public void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("\n⚠ No goals available.");
            return;
        }

        Console.WriteLine("\n✅ Record Progress on a Goal");
        ListGoals();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            score += goals[index].Points;
        }
        else
        {
            Console.WriteLine("❌ Invalid goal number.");
        }
    }
}
