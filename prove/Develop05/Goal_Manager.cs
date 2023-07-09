using System.Collections.Generic;
using System;

namespace Develop05
{
    public class Goal_Manager{
        private List<Goal> goals = new List<Goal>{};
        private int _score;

    public void modifyScore(int value){
        _score = _score + value;
    }

    public int GetScore(){
        return _score;
    }

    public void AddGoal(Goal goal){
        goals.Add(goal);
    }

    public void DisplayGoals(){
        int counter = 1;
        foreach (Goal goal in goals){
            string name = goal.GetGoal();
            string descript = goal.getDescription();
            if ((goal.GetType() == typeof(SimpleGoal)) || (goal.GetType() == typeof(EternalGoal))){
                if (goal.getCompletion() == false){
                     Console.WriteLine($"{counter}. [ ] {name} ({descript})");
                 }

                if (goal.getCompletion() != false){
                    Console.WriteLine($"{counter}. [x] {name} ({descript})");
                }
            }
            if (goal.GetType() == typeof(ChecklistGoal)){
                int progress = goal.GetProgress();
                int total = goal.GetTotal();
                 if (goal.getCompletion() == false){
                     Console.WriteLine($"{counter}. [ ] {name} ({descript}) -- Completed {progress}/{total}");
                 }

                if (goal.getCompletion() != false){
                    Console.WriteLine($"{counter}. [x] {name} ({descript}) -- Completed {progress}/{total}");
                }
            }
            counter = counter + 1;
        }
    }

    public void SaveGoals(string filename){

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in goals){
                string line = goal.ConverttoString();
                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadGoals(string filename){
        string[] lines = System.IO.File.ReadAllLines(filename);
        bool first_line = false;
        foreach (string line in lines)
        {
            if (first_line == false){
                int score = Convert.ToInt32(line);
                _score = score + _score;
                first_line = true;
            }
            string[] parts = line.Split(":");
            if (parts[0] == "simple"){
                SimpleGoal simple = new SimpleGoal(parts[1], Convert.ToInt32(parts[3]), parts[2]);
                simple.setCompletion(Convert.ToBoolean(parts[4]));
                goals.Add(simple);
            }

            if (parts[0] == "eternal"){
                EternalGoal eternal = new EternalGoal(parts[1], Convert.ToInt32(parts[3]), parts[2]);
                goals.Add(eternal);
            }

            if (parts[0] == "check"){
                ChecklistGoal check = new ChecklistGoal(parts[1], Convert.ToInt32(parts[3]), parts[2], Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                goals.Add(check);
            }
        }
    }

    public int RecordEvent(int choice){
        choice = choice - 1;
        int points = goals[choice].AccomplishGoal();
        this.modifyScore(points);
        return points;
    }
}
}