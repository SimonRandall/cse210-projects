using System.Collections.Generic;
using System;

namespace Develop04
{
    public class Breaathing_Exercise : Exercise{
        
        //private string description = "This activity will help you relax by walking your through breathing in and out slowly.\n Clear your mind and focus on your breathing.";

        public void Breath_Display(int duration){
            Console.Clear();
            DateTime currentTime = DateTime.Now;
            DateTime stopTime = currentTime.AddSeconds(duration);
            while(currentTime < stopTime){
                Console.Write("Breath in...");
                base.Counter(5);
                Console.WriteLine("\n");
                Console.Write("Breath Out...");
                base.Counter(5);
                Console.WriteLine("\n");
                Thread.Sleep(1000);
                currentTime = DateTime.Now;
            }
        }
        
}
}