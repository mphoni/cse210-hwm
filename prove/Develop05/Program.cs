using System;
using System.Collections.Generic;

namespace Develop5
{
    public class Program
    {
        private static List<Goals> goals1 = new List<Goals>();
        private static int score = 0;

        static void Main(string[] args)
        {
            while(true)
            {
                DisplayMenu();
                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        SaveGoals();
                        break;
                    case 3:
                        LoadGoals();
                        break;
                    case 4:
                        CurrentGoals();
                        break;
                    case 5:
                        CompleteGoal();
                        break;
                    case 6:
                        return;
                    
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }       

                        Console.WriteLine("Your score: " + score);
                        Console.WriteLine();
            }
        }    

        private static void DisplayMenu()
        {
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Save goals");
            Console.WriteLine("3. Load goals");
            Console.WriteLine("4. Current goals");
            Console.WriteLine("5. Complete goal");
            Console.WriteLine("6. Quit");
        }

        private static void CreateNewGoal()
        {
            
            Console.WriteLine("What type of goal do you want to create? ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Enter the type of goal: ");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter the goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a brief description: ");
            string description = Console.ReadLine(); 

            Goals goals;
            switch (type)
            {
                case 1:
                goals = new Simple(name, description);
                break;

                case 2:
                goals = new Eternal(name, description);
                break;
                        
                case 3:
                Console.Write("How many times do you want to achive this goal?");
                int itemCount = int.Parse(Console.ReadLine());
                goals = new Checklist(name, description, itemCount);
                break;
                       
                 default:
                    Console.WriteLine("invalid goal type. Try again");
                    return;
            }

                goals1.Add(goals);
        }

         private static void SaveGoals()
        {
            
            Console.WriteLine("Goals saved.");
        }

         private static void LoadGoals()
        {
          
            Console.WriteLine("Goals loaded.");
        }

          private static void CurrentGoals()
        {
            Console.WriteLine("=== Current Goals ===");
            foreach (Goals goal in goals1)
            {
                string completionStatus = goal.Completed ? "[X]" : "[ ]";

                if (goal is Checklist checklist)
                {
                    completionStatus += $" Completed {checklist.CompletedCount}/{checklist.itemCount} times";
                }

                Console.WriteLine($"{completionStatus} - {goal.Name} - {goal.Description}");
            }
        }

        private static void CompleteGoal()
        {
            if (goals1.Count == 0)
            {
                Console.WriteLine("No goals available to complete.");
                return;
            }

            Console.WriteLine("Select a goal to complete:");
            for (int i = 0; i < goals1.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals1[i].Name}");
            }

            Console.Write("Enter the goal number: ");
            int goalNumber = int.Parse(Console.ReadLine());

            if (goalNumber <= 0 || goalNumber > goals1.Count)
            {
                Console.WriteLine("Invalid goal number.");
                return;
            }

            Goals selectedGoal = goals1[goalNumber - 1];
            selectedGoal.Complete();
            score += selectedGoal.Points;

            Console.WriteLine("Goal completed! Points added to your score.");
        }
    }
}


