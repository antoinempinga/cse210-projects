using System;  

class Program  
{  
    static void Main(string[] args)  
    {  
        Console.WriteLine("Welcome!");
        Console.Write("What is your Name ?: ");
        string name = Console.ReadLine();
        Journal journal = new Journal();  
        bool running = true;  

        while (running)  
        {  
            Console.WriteLine($"Dear {name} this is the Journal Menu");
            Console.WriteLine("1. Write a new entry");  
            Console.WriteLine("2. Display journal");  
            Console.WriteLine("3. Save journal to file");  
            Console.WriteLine("4. Load journal from file");  
            Console.WriteLine("5. Exit");  
            Console.Write($"Dear{name} Kindly Choose an option: ");  
            string choice = Console.ReadLine();  

            switch (choice)  
            {  
                case "1":  
                    string prompt = journal.GetRandomPrompt();  
                    Console.WriteLine($"Prompt: {prompt}");  
                    Console.Write("Your response: ");  
                    string response = Console.ReadLine();  
                    journal.AddEntry(response);  
                    break;  
                case "2":  
                    journal.DisplayEntries();  
                    break;  
                case "3":  
                    Console.Write("Enter filename to save: ");  
                    string saveFileName = Console.ReadLine();  
                    journal.SaveToFile(saveFileName);  
                    Console.WriteLine("Journal saved.");  
                    break;  
                case "4":  
                    Console.Write("Enter filename to load: ");  
                    string loadFileName = Console.ReadLine();  
                    journal.LoadFromFile(loadFileName);  
                    Console.WriteLine("Journal loaded.");  
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
}

internal class Journal
{
    internal void AddEntry(string response)
    {
        throw new ImplementedException();
    }

    internal void DisplayEntries()
    {
        throw new ImplementedException();
    }

    internal string GetRandomPrompt()
    {
        throw new ImplementedException();
    }

    internal void LoadFromFile(string loadFileName)
    {
        throw new ImplementedException();
    }

    internal void SaveToFile(string saveFileName)
    {
        throw new ImplementedException();
    }
}

[Serializable]
internal class ImplementedException : Exception
{
    public ImplementedException()
    {
    }

    public ImplementedException(string message) : base(message)
    {
    }

    public ImplementedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}