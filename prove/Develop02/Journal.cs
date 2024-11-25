using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Add a new entry to the journal
    internal void AddEntry(Entry entry)
    {
        entries.Add(entry);
        Console.WriteLine("Entry added!");
    }

    // Display all journal entries
    internal void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry.Prompt}\n{entry.Response}\n");
        }
    }

    // Save journal entries to a file
    internal void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.Prompt);
                    writer.WriteLine(entry.Response);
                    writer.WriteLine("---"); // Entry separator
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the journal: {ex.Message}");
        }
    }

    // Load journal entries from a file
    internal void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        try
        {
            entries.Clear(); // Clear existing entries before loading new ones

            using (StreamReader reader = new StreamReader(filename))
            {
                string prompt = "";
                string response = "";

                while ((prompt = reader.ReadLine()) != null)
                {
                    response = reader.ReadLine();
                    if (response != null)
                    {
                        entries.Add(new Entry(prompt, response));
                    }
                    reader.ReadLine(); // Read the '---' separator
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}");
        }
    }
}
