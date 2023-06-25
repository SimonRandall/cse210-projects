using System.Collections.Generic;
using System;


namespace Develop04
{

    class Program
    {
        static void Main(string[] args){
            Console.Clear(); 
            bool loopBreaker = false;
            while (loopBreaker != true){
            Console.Write("Menu Options:\n   1. Start Breathing Activity\n   2. Start Reflecting Activity\n   3. Start Listening Activity\n   4. Quit\nSelect a choice from above:");
            string input = Console.ReadLine();
            int choice = Convert.ToInt32(input);

            if (choice == 1){
                Breaathing_Exercise breath = new Breaathing_Exercise();
                int duration = breath.Starter_Message("Breathing Exercise","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breath.Breath_Display(duration);
                breath.Ending_Message("Breathing Exericse", duration);
                breath.Animation(5);
            }

            if (choice == 2){
                Reflection_Exercise reflect = new Reflection_Exercise();
                int duration = reflect.Starter_Message("Reflection Exercise", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect.Reflection_Display(duration);
                reflect.Ending_Message("Reflection Exercise", duration);
                reflect.Animation(5);
            }

            if (choice == 3){
                Listening_Exercise listen = new Listening_Exercise();
                int duration = listen.Starter_Message("Listening Exercise", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                listen.Listening_Display(duration);
                listen.Ending_Message("Listening Exercise", duration);
                listen.Animation(5);
            }

            if (choice == 4){
                loopBreaker = true;
            }

            Console.Clear();

           }
        }
    }
}
