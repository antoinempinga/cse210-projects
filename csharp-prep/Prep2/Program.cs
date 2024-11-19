using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome!");
        Console.Write("What is your First Name ?: ");
        string Firstname = Console.ReadLine();
        Console.Write("What is your Last Name ? : ");
        string Lastname = Console.ReadLine();
        // Ask the user for their grade percentage
        Console.WriteLine($"Dear: {Firstname} {Lastname}, What is your grade percentage? :");
        int grade = int.Parse(Console.ReadLine());

        // Variable to store the letter grade
        string letter = "";

        // Determine the letter grade based on the percentage
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if the grade has a + or - sign based on the last digit
        string sign = "";
        if (letter != "F") // There are no "+" or "-" for an F grade
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Combine letter grade with the sign
        string finalGrade = letter + sign;

        // Output the final grade
        Console.WriteLine("Your final grade is: " + finalGrade);

        // Determine if the user passed or failed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass. Keep trying, you can do it next time!");
        }
        {
        Console.WriteLine($"Thanks so much Dear {Firstname} {Lastname} Good bye.");
        }
    }
}
