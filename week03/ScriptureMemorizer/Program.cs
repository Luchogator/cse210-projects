
using System;
using System.Collections.Generic;

/// <summary>
/// The main program that ties all classes together.
/// Manages user interaction and the scripture memorization process.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        if (Console.IsOutputRedirected == false)
        {
            Console.Clear();
        }
        Console.WriteLine("=========================================================");
        Console.WriteLine("           Welcome to the Scripture Memorizer!          ");
        Console.WriteLine("=========================================================");
        Console.WriteLine();

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding"),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son"),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd I shall not want")
        };

        while (true)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Start memorizing the scripture.");
            Console.WriteLine("2. Load scriptures from a file.");
            Console.WriteLine("3. Select a scripture from a list.");
            Console.WriteLine("4. Reveal a word as a hint.");
            Console.WriteLine("Type 'quit' to exit.");
            Console.Write("\nYour choice: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            switch (input)
            {
                case "1":
                    MemorizeScripture(scriptures[0]);
                    break;
                case "2":
                    Console.WriteLine("Feature not implemented yet: Loading scriptures from a file.\n");
                    break;
                case "3":
                    Scripture selectedScripture = SelectScriptureFromList(scriptures);
                    if (selectedScripture != null)
                    {
                        MemorizeScripture(selectedScripture);
                    }
                    break;
                case "4":
                    scriptures[0].RevealHint();
                    Console.WriteLine("\nHint revealed!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static void MemorizeScripture(Scripture scripture)
    {
        while (!scripture.IsCompletelyHidden())
        {
            if (Console.IsOutputRedirected == false)
            {
                Console.Clear();
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("                  Scripture Memorization                 ");
            Console.WriteLine("=========================================================\n");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nAll words are hidden. Well done!");
    }

    static Scripture SelectScriptureFromList(List<Scripture> scriptures)
    {
        Console.WriteLine("\nAvailable Scriptures:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].Reference.GetDisplayText()}");
        }

        Console.Write("Enter the number of the scripture you want to select: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int index) && index > 0 && index <= scriptures.Count)
        {
            return scriptures[index - 1];
        }
        else
        {
            Console.WriteLine("Invalid selection. Returning to main menu.");
            return null;
        }
    }
}
