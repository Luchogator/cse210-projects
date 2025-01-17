using System;

// -----------------------------------------------------------
// Program: If Statements - Exercise 2
// Author: Luis Eleazar Lizano Rojas
// Class: CSE 210 - Programming with Classes
// Description: A program that calculates a letter grade based 
// on a percentage entered by the user and provides feedback 
// based on the result.
// -----------------------------------------------------------

class CSharpExercise2_IfStatements
{
    static void Main(string[] args)
    {
        // Display a title for the program
        Console.WriteLine("===================================");
        Console.WriteLine("        Grade Calculator");
        Console.WriteLine("===================================");
        Console.WriteLine(); // Add spacing

        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage (%): ");
        string input = Console.ReadLine();

        // Convert the input to an integer
        int gradePercentage = int.Parse(input);

        // Determine the letter grade
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the grade sign (+ or -)
        string sign = "";

        if (letter != "F")
        {
            int lastDigit = gradePercentage % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }

            // Handle A+ case (not valid)
            if (letter == "A" && sign == "+")
            {
                sign = "";
            }
        }

        // Display the final grade with the sign
        Console.WriteLine();
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Check if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You'll get it next time.");
        }

        // Add spacing for a clean exit
        Console.WriteLine();
        Console.WriteLine("===================================");
    }
}
