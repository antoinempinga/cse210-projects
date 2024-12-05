using System;

class Program
{
    static void Main(string[] args)
    {
        string reference = "1 Corinthians 15:33";
        string scriptureText = "Be not deceived: evil communications corrupt good manners.";

        Scripture scripture = new Scripture(reference, scriptureText);

        // Start the game loop
        while (true)
        {
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();

            // Check if all words are hidden
            if (scripture.IsComplete())
            {
                scripture.DisplayScripture();
                Console.WriteLine("\nCongratulations! You've hidden all the words.");
                break;
            }
        }

        Console.WriteLine("\nProgram has ended.");
    }
}
