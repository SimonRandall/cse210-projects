using System.Collections.Generic;
using System;

namespace Develop05
{
    public class EternalGoal : Goal{

    public EternalGoal(string goal, int value, string descript){
        base.SetGoal(goal);
        base.SetWorth(value);
        base.setDescription(descript);
    }

    public override string ConverttoString()
    {
        string eternal = this.GetGoal();
        int worth = this.GetWorth();
        string descript = base.getDescription();
        return $"eternal:{eternal}:{descript}:{worth}";
    }

    public override int AccomplishGoal()
    {
            int points = this.GetWorth();
            return points;
    }



    }
}