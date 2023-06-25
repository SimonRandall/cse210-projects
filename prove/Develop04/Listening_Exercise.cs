using System.Collections.Generic;
using System;

namespace Develop04
{
    public class Listening_Exercise : Exercise{

        private List<string> _prompts;

        public Listening_Exercise(){
            _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        }
        
        
        public void Listening_Display(int duration){
            string prompt = base.RandomPrompt(_prompts);
            Console.Clear();
            Console.WriteLine($"List as many responses to the following prompt as you can:\n--{prompt}--\nYou many begin in...");
            base.Counter(5);
            DateTime currentTime = DateTime.Now;
            DateTime stopTime = currentTime.AddSeconds(duration);
            List<string> answers = new List<string>{};
            while (currentTime < stopTime){
                string ans = Console.ReadLine();
                answers.Add(ans);
                currentTime = DateTime.Now;
            }
            int responses = answers.Count();
            Console.WriteLine($"You Wrote {responses} Responses");
            base.Animation(7);
        }
        
}
}