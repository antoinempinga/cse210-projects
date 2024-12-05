using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    // GoalManager: Manages the list of goals and user interaction
    public class GoalManager
    {
        private List<Goal> goals = new List<Goal>();
        private int totalPoints = 0;

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void ListGoals()
        {
            Console.WriteLine("\nGoals List:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetDetails());
            }
        }

        public void RecordGoalEvent(int goalIndex)
        {
            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                goals[goalIndex].RecordEvent();
                totalPoints += goals[goalIndex].Points;
                Console.WriteLine($"Total Points: {totalPoints}\n");
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public void ShowTotalPoints()
        {
            Console.WriteLine($"Total points: {totalPoints}");
        }

        public void SaveProgress(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(totalPoints);
                foreach (var goal in goals)
                {
                    writer.WriteLine($"{goal.Name},{goal.Description},{goal.IsComplete}");
                }
            }
            Console.WriteLine("Progress saved.");
        }

        public void LoadProgress(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    totalPoints = int.Parse(reader.ReadLine());
                    goals.Clear();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        string name = parts[0];
                        string description = parts[1];
                        bool isComplete = bool.Parse(parts[2]);

                        // Just a simple demonstration of how goals are loaded
                        if (isComplete)
                        {
                            goals.Add(new SimpleGoal(name, description) { IsComplete = isComplete });
                        }
                        else
                        {
                            goals.Add(new EternalGoal(name, description) { IsComplete = isComplete });
                        }
                    }
                }
                Console.WriteLine("Progress loaded.");
            }
            else
            {
                Console.WriteLine("No saved progress found.");
            }
        }
    }
}
