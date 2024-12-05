using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;

    public virtual void StartActivity()
    {
        // Start the activity with a common message
        Console.WriteLine($"Starting {this.GetType().Name}...");
        Console.WriteLine("Please enter the duration for this activity (in seconds):");
        duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);  // Pause for a few seconds

        // Call specific start and finish behavior of each activity
        StartSpecificActivity();
        EndActivity();
    }

    protected abstract void StartSpecificActivity();

    private void EndActivity()
    {
        // Common end message
        Console.WriteLine("Great job! You have completed the activity.");
        Thread.Sleep(2000);  // Pause before finishing
    }
}
