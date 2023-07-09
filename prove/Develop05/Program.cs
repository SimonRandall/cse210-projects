using System;

namespace Develop05{
class Program
{
    static void Main(string[] args)
    {
        Goal_Manager manager = new Goal_Manager();
        bool loopBreaker = false;
        while (loopBreaker == false){
            int score = manager.GetScore();
            Console.WriteLine($"You have {score} points!\n");
            Console.WriteLine("Menu Options\n 1.Create New Goal\n 2.List Goals\n 3.Save Goals\n 4.Load Goals\n 5.Record Event\n 6.Quit");
            string choice = Console.ReadLine();

            if (choice == "1"){
                Console.WriteLine("What kind of goal:\n 1.Simple Goal\n 2.Eternal Goal\n 3.Checklist Goal");
                string choice2 = Console.ReadLine();
                if (choice2 == "1"){
                    Console.WriteLine("What is the name of your goal?");
                    string goal = Console.ReadLine();
                    Console.WriteLine("Give a short description of your goal:");
                    string description = Console.ReadLine();
                    Console.WriteLine("How much points is this goal worth?");
                    string s_worth = Console.ReadLine();
                    int worth = Convert.ToInt32(s_worth);
                    SimpleGoal simple = new SimpleGoal(goal, worth, description);
                    manager.AddGoal(simple);
                }
                if (choice2 == "2"){
                    Console.WriteLine("What is the name of your goal?");
                    string goal = Console.ReadLine();
                    Console.WriteLine("Give a short description of your goal:");
                    string description = Console.ReadLine();
                    Console.WriteLine("How much points is this goal worth?");
                    string s_worth = Console.ReadLine();
                    int worth = Convert.ToInt32(s_worth);
                    EternalGoal eternal = new EternalGoal(goal, worth, description);
                    manager.AddGoal(eternal);
                }
                if (choice2 == "3"){
                    Console.WriteLine("What is the name of your goal?");
                    string goal = Console.ReadLine();
                    Console.WriteLine("Give a short description of your goal:");
                    string description = Console.ReadLine();
                    Console.WriteLine("How much points is this goal worth?");
                    string s_worth = Console.ReadLine();
                    int worth = Convert.ToInt32(s_worth);
                    Console.WriteLine("How many times will you do this goal?");
                    string s_total = Console.ReadLine();
                    int total = Convert.ToInt32(s_total);
                    Console.WriteLine("What is the bonus for accomplishing this goal");
                    string s_bonus = Console.ReadLine();
                    int bonus = Convert.ToInt32(s_bonus);
                    ChecklistGoal check = new ChecklistGoal(goal, worth, description, 0, total, bonus);
                    manager.AddGoal(check);
                }
            }

            if (choice == "2"){
                Console.WriteLine("Your Goals Are:");
                manager.DisplayGoals();
            }

            if (choice == "3"){
                Console.WriteLine("Where would you like to save your goals?");
                string filename = Console.ReadLine();
                manager.SaveGoals(filename);
            }

            if (choice == "4"){
                Console.WriteLine("Where would you like to load your goals from?");
                string filename = Console.ReadLine();
                manager.LoadGoals(filename);
            }

            if (choice == "5"){
                Console.WriteLine("Pick a goal:");
                manager.DisplayGoals();
                int goal_choice = Convert.ToInt32(Console.ReadLine());
                int points = manager.RecordEvent(goal_choice);
                Console.WriteLine($"You just got {points} points");
            }

            if (choice == "6"){
                loopBreaker = true;
            }

        }
    }
}
}