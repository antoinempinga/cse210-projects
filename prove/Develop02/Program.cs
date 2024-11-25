using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome!");
            Console.Write("What is your Name ?: ");
            string name = Console.ReadLine();        
            Console.Clear();
            Console.WriteLine($"Dear: {name}, Once again welcome to the Journal Program!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    journal.DisplayEntries();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "3":
                    SaveJournalToFile(journal);
                    break;
                case "4":
                    LoadJournalFromFile(journal);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal)
    {
        string prompt = journal.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        journal.AddEntry(prompt, response);
    }

    static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter the filename to load the journal from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}

internal class Journal
{
    internal void AddEntry(string prompt, string response)
    {
        throw new NotImplementedException();
    }

    internal void DisplayEntries()
    {
        throw new NotImplementedException();
    }

    internal string GetRandomPrompt()
    {
        throw new NotImplementedException();
    }

    internal void LoadFromFile(string filename)
    {
        throw new NotImplementedException();
    }

    internal void SaveToFile(string filename)
    {
        throw new NotImplementedException();
    }
}