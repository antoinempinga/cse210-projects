using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override void StartSpecificActivity()
    {
        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {selectedPrompt}");
        Thread.Sleep(2000);

        foreach (var question in reflectionQuestions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000);  // Wait 3 seconds before asking the next question
        }
    }
}
