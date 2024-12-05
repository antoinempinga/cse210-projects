using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.Write("What is your Name ?: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Thanks so much {name}");

        // Show the activity menu
        while (true)
        {
            Console.WriteLine("\nPlease select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                 case "4":
                    Console.WriteLine($"Thanks {name} dear Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            // Start the selected activity
            activity.StartActivity();
        }
    }
}
