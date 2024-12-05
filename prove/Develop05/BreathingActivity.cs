using System;
using System.Threading;

public class BreathingActivity : Activity
{
    protected override void StartSpecificActivity()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Thread.Sleep(2000);  // Pause to explain the activity

        int count = 0;
        while (count < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown();
            Console.WriteLine("Breathe out...");
            ShowCountdown();
            count += 4;  // Each in/out sequence takes 4 seconds
        }
    }

    private void ShowCountdown()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write(i + "...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
