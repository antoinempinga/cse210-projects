using System;

namespace EternalQuest
{
    // Base class for all types of goals
    public abstract class Goal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; protected set; }
        public bool IsComplete { get; set; }

        public Goal(string name, string description)
        {
            Name = name;
            Description = description;
            IsComplete = false;
        }

        // Abstract method to record the event of accomplishing the goal
        public abstract void RecordEvent();
        public abstract string GetDetails();
    }

    // SimpleGoal: a goal that is completed once
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description) : base(name, description)
        {
            Points = 1000; // Fixed points for a completed goal
        }

        public override void RecordEvent()
        {
            IsComplete = true;
            Console.WriteLine($"You have completed the goal: {Name} and earned {Points} points!");
        }

        public override string GetDetails()
        {
            return IsComplete ? "[X] " + Name : "[ ] " + Name;
        }
    }

    // EternalGoal: a goal that can be recorded multiple times
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description) : base(name, description)
        {
            Points = 100; // Fixed points for each record
        }

        public override void RecordEvent()
        {
            Points += 100; // Increment points on each record
            Console.WriteLine($"You have earned 100 points for completing: {Name}. Total points: {Points}");
        }

        public override string GetDetails()
        {
            return "[ ] " + Name + " (Eternal Goal)";
        }
    }

    // ChecklistGoal: a goal that needs to be completed a certain number of times
    public class ChecklistGoal : Goal
    {
        public int Target { get; set; }
        public int Progress { get; set; }

        public ChecklistGoal(string name, string description, int target) : base(name, description)
        {
            Target = target;
            Progress = 0;
            Points = 50; // Points for each event
        }

        public override void RecordEvent()
        {
            Progress++;
            Points += 50; // Points for each recorded event
            Console.WriteLine($"You have earned 50 points for completing: {Name}. Progress: {Progress}/{Target}.");

            if (Progress == Target)
            {
                Points += 500; // Bonus points for completing the checklist goal
                Console.WriteLine($"Congratulations! You've completed the goal {Name}. Bonus of 500 points awarded!");
            }
        }

        public override string GetDetails()
        {
            return $"{Name} - Completed {Progress}/{Target} times";
        }
    }
}
