using System.Collections.Generic;
using System;

namespace Develop02
{
    ///The responsibility of an Entry is to store a prompt, response and date.
    public class Entry{
       public string prompt;
       public string response;
       public string date;

       public void CreateEntry(string RandomPrompt){
            prompt = RandomPrompt;
            DateTime theCurrentTime = DateTime.Now;
            date = theCurrentTime.ToShortDateString();
            Console.WriteLine(prompt);
            response = Console.ReadLine();
            
       }

       public string GetPrompt(){
        return prompt;
       }

       public string GetResponse(){
        return response;
       }

       public string GetDate(){
        return date;
       }

       public void SetEntry(string new_prompt, string new_response, string new_date){
            prompt = new_prompt;
            response = new_response;
            date = new_date;
       }
    }
}