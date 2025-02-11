using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"🔹 Welcome to the {_name} Activity!\n");
        Console.WriteLine(_description);
        Console.Write("\n⏳ Enter the duration in seconds: ");
        
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("❌ Invalid input. Please enter a positive number.");
            Console.Write("\n⏳ Enter the duration in seconds: ");
        }

        Console.WriteLine("\n🚀 Get ready...");
        Utils.ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n✅ Great job! You have completed the activity.");
        Console.WriteLine($"⏳ Duration: {_duration} seconds in {_name} Activity.");
        Utils.ShowSpinner(3);
    }
}
