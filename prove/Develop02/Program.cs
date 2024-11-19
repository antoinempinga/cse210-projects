using System;
using System.Collections.Generic;

namespace JournalApp
{
    // Abstract class defining a general structure for all types of Entries
    public abstract class Entry
    {
        public string Date { get; set; }
        public string Text { get; set; }

        // Abstract method that will be implemented by concrete subclasses
        public abstract void Display();
    }

    // Concrete class that represents a text-based journal entry
    public class TextEntry : Entry
    {
        public override void Display()
        {
            Console.WriteLine($"[Text Entry] {Date}: {Text}");
        }
    }

    // Concrete class for an image-based journal entry (could be expanded later)
    public class ImageEntry : Entry
    {
        public string ImagePath { get; set; }

        public override void Display()
        {
            Console.WriteLine($"[Image Entry] {Date}: {Text}, Image Path: {ImagePath}");
        }
    }

    // Journal class that contains a list of Entries
    public class Journal
    {
        private List<Entry> entries = new List<Entry>();

        // Method to add entries to the journal
        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        // Method to display all entries in the journal
        public void DisplayAllEntries()
        {
            foreach (var entry in entries)
            {
                entry.Display();  // Abstraction in action: we don't care about the concrete type of Entry
            }
        }
    }

    // Program entry point
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new journal
            Journal myJournal = new Journal();

            // Add a text-based entry
            myJournal.AddEntry(new TextEntry { Date = "2024-11-15", Text = "This is my first journal entry!" });

            // Add an image-based entry
            myJournal.AddEntry(new ImageEntry { Date = "2024-11-16", Text = "A beautiful sunset!", ImagePath = "/images/sunset.jpg" });

            // Display all entries
            myJournal.DisplayAllEntries();
        }
    }
}
