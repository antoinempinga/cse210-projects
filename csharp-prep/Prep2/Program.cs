using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        Console.Write("What is your First Name ?: ");
        string Firstname = Console.ReadLine();
        Console.Write("What is your Last Name ? : ");
        string Lastname = Console.ReadLine();
        Console.WriteLine($"Dear: {Firstname} {Lastname}, What is your grade percentage? :");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
        Console.WriteLine($"Thanks so much {Firstname} {Lastname} for testing your grade.");
        Console.WriteLine("Good Bye.");
    }
}