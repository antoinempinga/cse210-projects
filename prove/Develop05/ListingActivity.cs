using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private static readonly List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void StartSpecificActivity()
    {
        Random rand = new Random();
        string selectedPrompt = listingPrompts[rand.Next(listingPrompts.Count)];
        Console.WriteLine($"Prompt: {selectedPrompt}");
        Thread.Sleep(2000);

        Console.WriteLine("Start listing... Press Enter after each item.");
        List<string> userList = new List<string>();

        int startTime = Environment.TickCount;
        while (Environment.TickCount - startTime < duration * 1000)
        {
            string userInput = Console.ReadLine();
            userList.Add(userInput);
        }

        Console.WriteLine($"You listed {userList.Count} items!");
    }
}
