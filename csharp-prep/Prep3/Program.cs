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
        Console.WriteLine($"Dear: {Firstname} {Lastname}, not that this is a magic number game");
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"Thanks so much Dear {Firstname} {Lastname}Good bye.");
            }

        }              
    }
}