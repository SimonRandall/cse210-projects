using System.Collections.Generic;
using System;

namespace Develop05
{
    public abstract class Goal{
        private string _goal;
        private string _description;
        private int _worth;
        private bool completion = false;

    public string GetGoal(){
        return _goal;
    }

    public int GetWorth(){
        return _worth;
    }

    public void SetGoal(string goal){
        _goal = goal;
    }

    public void SetWorth(int worth){
        _worth = worth;
    }

    public void setCompletion(bool comp){
        completion = comp;
    }

    public bool getCompletion(){
        return completion;
    }

    public void setDescription(string des){
        _description = des;
    }

    public string getDescription(){
        return _description;
    }

    public abstract int AccomplishGoal();

    public abstract string ConverttoString();
    public virtual int GetProgress(){
        return 1;
    }
    public virtual int GetTotal(){
        return 1;
    }

    }
}