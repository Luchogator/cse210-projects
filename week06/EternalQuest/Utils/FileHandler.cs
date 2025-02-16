using System;
using System.Collections.Generic;
using System.IO;

public static class FileHandler
{
    private static string filePath = "Data/goals.txt"; // Using .txt instead of JSON

    public static void SaveGoals(List<Goal> goals, int score, int level)
    {
        try
        {
            // Ensure the directory exists before saving
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

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

    public static (List<Goal>, int, int) LoadGoals()
    {
        if (!File.Exists(filePath)) return (new List<Goal>(), 0, 1);

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            int score = int.Parse(lines[0]);
            int level = int.Parse(lines[1]);
            List<Goal> goals = new List<Goal>();

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
            return (goals, score, level);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠ Error loading goals: {ex.Message}");
            return (new List<Goal>(), 0, 1);
        }
    }
}
