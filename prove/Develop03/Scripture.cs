using System;
using System.Collections.Generic;

public class Scripture
{
    public ScriptureReference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = new ScriptureReference(reference);
        Words = new List<Word>();
        var wordArray = text.Split(' ');

        foreach (var word in wordArray)
        {
            Words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(Reference);
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random rand = new Random();
        int wordIndex = rand.Next(0, Words.Count);
        Words[wordIndex].IsHidden = true;
    }

    public bool IsComplete()
    {
        foreach (var word in Words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }
}
