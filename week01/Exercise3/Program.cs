using System;

// -----------------------------------------------------------
// Program: Loops - Exercise 3
// Author: Luis Eleazar Lizano Rojas
// Class: CSE 210 - Programming with Classes
// Description: A "Guess My Number" game where the computer 
// selects a magic number, and the user tries to guess it 
// with hints provided for each guess.
// -----------------------------------------------------------

class CSharpExercise3_Loops
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Display the title
            Console.WriteLine("===================================");
            Console.WriteLine("       Guess My Number Game");
            Console.WriteLine("===================================");
            Console.WriteLine();

            // Create a random number generator
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0; // Initialize the user's guess
            int attempts = 0; // Keep track of the number of attempts

            // Game loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display the number of attempts
            Console.WriteLine($"It took you {attempts} attempts to guess the number.");
            Console.WriteLine();

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
            Console.WriteLine();
        }

        // Goodbye message
        Console.WriteLine("Thank you for playing! Goodbye!");
        Console.WriteLine("===================================");
    }
}
