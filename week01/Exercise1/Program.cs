using System;

// -----------------------------------------------------------
// Program: Input and Output - Exercise 1
// Author: Luis Eleazar Lizano Rojas
// Class: CSE 210 - Programming with Classes
// Description: A simple program that formats and displays 
// the user's name in a Bond-style format.
// -----------------------------------------------------------

class CSharpExercise1_InputOutput
{
    static void Main(string[] args)
    {
        // Displaying a title
        Console.WriteLine("===================================");
        Console.WriteLine("  Welcome to the Name Formatter!  ");
        Console.WriteLine("===================================");
        Console.WriteLine(); // Add a blank line for spacing

        // Initialize variables
        string firstName = string.Empty;
        string lastName = string.Empty;

        // Prompting the user for their first name
        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine() ?? string.Empty;

        // Prompting the user for their last name
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine() ?? string.Empty;

        // Validating input to ensure fields are not empty
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("\nError: Both first and last names are required.");
            return;
        }

        Console.WriteLine(); // Add another blank line for spacing

        // Displaying the formatted name in the Bond-style format
        Console.WriteLine("-----------------------------------");
        PrintFormattedName(firstName, lastName);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(); // Add a final blank line
    }

    /// <summary>
    /// Formats and prints the user's name in the desired output style.
    /// </summary>
    /// <param name="first">The user's first name</param>
    /// <param name="last">The user's last name</param>
    static void PrintFormattedName(string first, string last)
    {
        // Using string interpolation to construct the output message
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}
