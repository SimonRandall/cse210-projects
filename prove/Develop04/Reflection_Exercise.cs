using System.Collections.Generic;
using System;

namespace Develop04
{
    public class Reflection_Exercise : Exercise{
        
       private List<string> _prompts;
       private List<string> _questions;

       public Reflection_Exercise(){
        _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

       }


        public void Reflection_Display(int duration){
            Console.Clear();
            string prompt = base.RandomPrompt(_prompts);
            Console.WriteLine($"Consider the following prompt:\n --{prompt}--\nPress Enter to Continue");
            DateTime currentTime = DateTime.Now;
            DateTime stopTime = currentTime.AddSeconds(duration);
            string start = Console.ReadLine();
            if (start == ""){
                Console.Clear();
                string question;
                while(currentTime < stopTime){
                    question = base.RandomPrompt(_questions);
                    Console.WriteLine(question);
                    base.Animation(6);
                    currentTime = DateTime.Now;
                }
            }            
            
        }
        
}
}