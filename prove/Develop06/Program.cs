using System;

namespace EternalQuest
{
    public class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            goalManager.LoadProgress("progress.txt");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your Eternal Quest!");
                Console.WriteLine("1. List Goals");
                Console.WriteLine("2. Add Simple Goal");
                Console.WriteLine("3. Add Eternal Goal");
                Console.WriteLine("4. Add Checklist Goal");
                Console.WriteLine("5. Record Goal Event");
                Console.WriteLine("6. Show Total Points");
                Console.WriteLine("7. Save Progress");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        goalManager.ListGoals();
                        break;
                    case "2":
                        goalManager.AddGoal(new SimpleGoal("Run a Marathon", "Complete a marathon"));
                        break;
                    case "3":
                        goalManager.AddGoal(new EternalGoal("Read Scriptures", "Read scriptures daily"));
                        break;
                    case "4":
                        goalManager.AddGoal(new ChecklistGoal("Attend Temple", "Attend the temple", 10));
                        break;
                    case "5":
                        Console.Write("Enter the goal index to record an event: ");
                        int goalIndex = int.Parse(Console.ReadLine());
                        goalManager.RecordGoalEvent(goalIndex);
                        break;
                    case "6":
                        goalManager.ShowTotalPoints();
                        break;
                    case "7":
                        goalManager.SaveProgress("progress.txt");
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
