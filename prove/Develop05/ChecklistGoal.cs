using System.Collections.Generic;
using System;

namespace Develop05
{
    public class ChecklistGoal : Goal{
        private int total_times;
        private int number_times;
        private int _bonus;

    public ChecklistGoal(string goal, int value, string descript, int number, int total, int bonus){
        base.SetGoal(goal);
        base.SetWorth(value);
        base.setDescription(descript);
        number_times = number;
        total_times = total;
        _bonus = bonus;
    }

    public override string ConverttoString()
    {
        string check = this.GetGoal();
        int worth = this.GetWorth();
        string descript = base.getDescription();
        return $"check:{check}:{descript}:{worth}:{number_times}:{total_times}:{_bonus}";
    }

    public override int AccomplishGoal()
    {
            int points = this.GetWorth();
            number_times = number_times + 1;
            if (number_times == total_times){
                base.setCompletion(true);
                points = points + _bonus;
            }
            return points;
    }

    public override int GetTotal(){
        return total_times;
    }

    public override int GetProgress(){
        return number_times;
    }



    }
}