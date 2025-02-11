using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax by guiding your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("\n🫁 Breathe in...");
            Utils.ShowCountDown(3);
            Console.WriteLine("\n😌 Breathe out...");
            Utils.ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}
