using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _remainingQuestions;

    public ReflectingActivity() : base("Reflecting", "This activity helps you reflect on personal growth.")
    {
        _remainingQuestions = new List<string>(_questions);
        ShuffleList(_remainingQuestions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = Utils.GetRandomPrompt(_prompts);
        Console.WriteLine($"\n💭 {prompt}");
        Utils.ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            if (_remainingQuestions.Count == 0)
            {
                _remainingQuestions = new List<string>(_questions);
                ShuffleList(_remainingQuestions);
            }

            string question = _remainingQuestions[0];
            _remainingQuestions.RemoveAt(0);
            Console.WriteLine("\n📌 " + question);
            Utils.ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private void ShuffleList(List<string> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            string value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
