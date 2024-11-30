using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the scripture
        Reference reference = new Reference("John", 14, 1);
        string scriptureText =
            "Let not your heart be troubled: ye believe in God, believe also in me.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main program loop
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        // Final display
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());
        Console.WriteLine("\nAll words have been hidden. Program ending.");
    }
}