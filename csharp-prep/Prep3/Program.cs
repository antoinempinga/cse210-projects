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
        Console.WriteLine($"Dear: {Firstname} {Lastname}, not that this is a magic number game");
        // Core functionality
        int magicNumber = 18; // Initially ask user to input magic number
        int guess;

        Console.WriteLine("What is the magic number?");
        magicNumber = int.Parse(Console.ReadLine()); // User inputs the magic number
        
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine()); // User makes a guess

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

        } while (guess != magicNumber); // Loop continues until the user guesses correctly
                            {
                Console.WriteLine($"Thanks so much Dear {Firstname} {Lastname}Good bye.");
            }
    }
}
