
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to your Personal Journal!");
        Console.WriteLine("This program helps you write and manage your daily journal.\n");

        while (true)
        {
            Console.WriteLine("====== MENU ======");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Search entries"); // New search option
            Console.WriteLine("==================");
            Console.Write("Choose an option (1-6): ");
            string choice = Console.ReadLine();
            Console.WriteLine(); // Espaciado para mejor visualización

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                journal.AddEntry(new Entry(date, prompt, response));
                Console.WriteLine("\nEntry added successfully!\n");
            }
            else if (choice == "2")
            {
                Console.WriteLine("=== Journal Entries ===");
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save the journal: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load the journal: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nThank you for using the Personal Journal Program!");
                Console.WriteLine("Have a great day! Goodbye!\n");
                break;
            }
            else if (choice == "6") // Option 6: Search entries
            {
                Console.Write("Enter a date or keyword to search: ");
                string query = Console.ReadLine();
                journal.SearchEntries(query);
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.\n");
            }
        }
    }
}
