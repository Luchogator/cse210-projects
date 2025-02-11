using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity encourages you to list positive aspects of life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = Utils.GetRandomPrompt(_prompts);
        Console.WriteLine($"\n📝 {prompt}");
        Utils.ShowCountDown(5);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\n➕ Enter an item: ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\n✅ You listed {responses.Count} items.");
        DisplayEndingMessage();
    }
}
