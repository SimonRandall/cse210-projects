using System.Collections.Generic;
using System;

namespace Develop04
{
    ///The responsibility of the scripture class is to provide a string of the scripture.
    public class Exercise{

        public string RandomPrompt(List<string> prompts){
            Random rnd = new Random();
            int length = prompts.Count();
            int num = rnd.Next(0,length);
            string prompt = prompts[num];
            return prompt;
            
        }

        public void Animation(int delay){
            DateTime currentTime = DateTime.Now;
            DateTime stopTime = currentTime.AddSeconds(delay);
            while (currentTime < stopTime){
                Console.Write("|");
                Thread.Sleep(200);
                Console.Write("\b\b");
                Console.Write("/");
                Thread.Sleep(200);
                Console.Write("\b\b");
                Console.Write("—");
                Thread.Sleep(200);
                Console.Write("\b\b");
                
                currentTime = DateTime.Now;

            }
        }

        public void Counter(int start){
            while (start != 0){
                Console.Write(start);
                Thread.Sleep(1000);
                Console.Write("\b");
                start = start - 1;
            }
            Console.Write(" ");

        }

        public int Starter_Message(string name, string description){
            Console.Clear();
            Console.WriteLine($"Welcome to {name} Exercise!");
            Console.Write("\n\n");
            Console.WriteLine(description);
            Console.Write("How long, in seconds, would you like the session to be?");
            string val = Console.ReadLine();
            int time = Convert.ToInt32(val);
            return time;
        }

        public void Ending_Message(string name ,int duration){
            Console.Clear();
            Console.WriteLine("Well Done!");
            Console.WriteLine($"You completed a {duration} second session of {name} Activity.");
        }
}
}