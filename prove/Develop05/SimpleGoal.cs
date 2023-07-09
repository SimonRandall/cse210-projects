using System.Collections.Generic;
using System;

namespace Develop05
{
    public class SimpleGoal : Goal{

    public SimpleGoal(string goal, int value, string descript){
        base.SetGoal(goal);
        base.SetWorth(value);
        base.setDescription(descript);
    }

    public override string ConverttoString()
    {
        string simple_goal = this.GetGoal();
        int worth = this.GetWorth();
        string descript = base.getDescription();
        bool completion = base.getCompletion();
        return $"simple:{simple_goal}:{descript}:{worth}:{completion}";
    }

    public override int AccomplishGoal()
    {
            int points = this.GetWorth();
            base.setCompletion(true);
            return points;
    }



    }
}