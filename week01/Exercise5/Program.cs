using System;

// -----------------------------------------------------------
// Program: Functions - Exercise 5
// Author: Luis Eleazar Lizano Rojas
// Class: CSE 210 - Programming with Classes
// Description: A program that demonstrates the use of 
// functions by performing simple tasks such as displaying 
// a welcome message, prompting user input, and calculating
// the square of a number.
// -----------------------------------------------------------

class CSharpExercise5_Functions
{
    static void Main(string[] args)
    {
        // Display the welcome message
        DisplayWelcome();

        // Get the user's name
        string userName = PromptUserName();

        // Get the user's favorite number
        int userNumber = PromptUserNumber();

        // Calculate the square of the number
        int squaredNumber = SquareNumber(userNumber);

        // Display the result
        DisplayResult(userName, squaredNumber);

        // Closing message
        Console.WriteLine("===================================");
        Console.WriteLine("      Thank you for using the      ");
        Console.WriteLine("      Functions Program!           ");
        Console.WriteLine("===================================");
    }

    /// <summary>
    /// Displays a welcome message to the user.
    /// </summary>
    static void DisplayWelcome()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("       Welcome to the Program      ");
        Console.WriteLine("===================================");
        Console.WriteLine();
    }

    /// <summary>
    /// Prompts the user for their name and returns it.
    /// </summary>
    /// <returns>The user's name as a string.</returns>
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    /// <summary>
    /// Prompts the user for their favorite number and returns it.
    /// </summary>
    /// <returns>The user's favorite number as an integer.</returns>
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();

        // Validate input to ensure it's an integer
        while (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("Please enter your favorite number: ");
            input = Console.ReadLine();
        }

        return int.Parse(input);
    }

    /// <summary>
    /// Accepts an integer and returns its square.
    /// </summary>
    /// <param name="number">The number to square.</param>
    /// <returns>The squared number.</returns>
    static int SquareNumber(int number)
    {
        return number * number;
    }

    /// <summary>
    /// Displays the user's name and the squared number.
    /// </summary>
    /// <param name="name">The user's name.</param>
    /// <param name="squaredNumber">The squared number to display.</param>
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine();
        Console.WriteLine("===================================");
        Console.WriteLine($" {name}, the square of your number ");
        Console.WriteLine($"               is {squaredNumber}             ");
        Console.WriteLine("===================================");
    }
}
