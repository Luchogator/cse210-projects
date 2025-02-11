using System;
using System.Collections.Generic;
using System.Threading;

public static class Utils
{
    public static void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public static void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public static string GetRandomPrompt(List<string> list)
    {
        Random random = new Random();
        return list[random.Next(list.Count)];
    }
}
