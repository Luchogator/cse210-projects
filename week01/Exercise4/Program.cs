using System;
using System.Collections.Generic;

// -----------------------------------------------------------
// Program: Lists and Generics - Exercise 4
// Author: Luis Eleazar Lizano Rojas
// Class: CSE 210 - Programming with Classes
// Description: A program that collects a list of numbers, 
// performs various calculations, and displays the results.
// -----------------------------------------------------------

class CSharpExercise4_Lists
{
    static void Main(string[] args)
    {
        // Display the title
        Console.WriteLine("===================================");
        Console.WriteLine("       List Operations Program");
        Console.WriteLine("===================================");
        Console.WriteLine();

        // Initialize the list
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;

        // Collect numbers from the user
        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            // Validate input to ensure it is a valid integer
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Core Requirements
        if (numbers.Count > 0)
        {
            // Compute the sum
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            // Compute the average
            double average = (double)sum / numbers.Count;

            // Find the maximum number
            int max = int.MinValue;
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            // Display results
            Console.WriteLine();
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenges
            // Find the smallest positive number
            int smallestPositive = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }

            // Only display smallest positive if a positive number exists
            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers in the list.");
            }

            // Sort the list
            numbers.Sort();

            // Display the sorted list
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

        // End of program
        Console.WriteLine("===================================");
    }
}
