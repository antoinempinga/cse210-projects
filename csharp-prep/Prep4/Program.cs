using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello!");
        Console.Write("What is your  Name ?: ");
        string Name = Console.ReadLine();
        Console.WriteLine($"Welcome {Name} !");

        // Step 1: Create a list to store the numbers
        List<int> numbers = new List<int>();

        // Prompt user for input
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Step 2: Collect user input
        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);  // Add to the list if it's not 0
            }

        } while (number != 0);  // Stop when user enters 0

        // Step 3: Calculate sum, average, and max
        if (numbers.Count > 0)
        {
            // Calculate sum
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }

            // Calculate average
            double average = (double)sum / numbers.Count;

            // Find maximum number
            int max = int.MinValue;
            foreach (int n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }

            // Display the results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenge (Optional)
            // Find smallest positive number closest to zero
            int smallestPositive = int.MaxValue;
            foreach (int n in numbers)
            {
                if (n > 0 && n < smallestPositive)
                {
                    smallestPositive = n;
                }
            }

            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Sort the list and display the sorted numbers
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        Console.WriteLine($"Thanks so much Dear {Name} Good bye.");
    }
}
