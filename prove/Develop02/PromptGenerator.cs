using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What is your favorite childhood memory?",
        "What are you grateful for today?",
        "What is something you've learned recently?",
        "What challenges are you facing right now?",
        "What are your goals for the next month?"
    };

    private Random random = new Random();  // Reuse the Random instance

    public string GetRandomPrompt()
    {
        return prompts[random.Next(prompts.Count)];
    }
}
