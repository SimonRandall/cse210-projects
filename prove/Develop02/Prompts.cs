using System.Collections.Generic;
using System;

namespace Develop02
{
    ///The responsibility to provide random prompts
    public class Prompts{
        List<string> prompts;
        public Prompts(){
            prompts = new List<string>();
            prompts.Add("What was your favourite thing you ate today?");
            prompts.Add("How many times did you sneeze today?");
            prompts.Add("What did you program today?");
            prompts.Add("What was the worst prompt you have seen today?");
            prompts.Add("What is the most boring thing you did today?");
        }

      public string GetRandomPrompt(){
            int len = prompts.Count;
            Random rnd = new Random();
            int num = rnd.Next(0,len);
            return prompts[num];


       }
    }
}