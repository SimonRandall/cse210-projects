using System;

namespace Develop02{
class Program
{
    static void Main(string[] args)
    {
       Console.Clear(); 
       Console.WriteLine("Welcome to the Journal Program!"); 
       bool loopBreaker = false;
       Journal journal = new Journal();
       while (loopBreaker != true){
            Console.WriteLine("Please Choose one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            string choice = Console.ReadLine();

            if (choice == "1"){
                Entry new_entry = new Entry();
                Prompts prompts = new Prompts();
                string prompt = prompts.GetRandomPrompt();
                new_entry.CreateEntry(prompt);
                journal.AddEntry(new_entry);

            }

            if (choice == "2"){
                journal.DisplayJournal();
            }

            if (choice == "3"){
                journal.LoadJournal();
            }

            if (choice == "4"){
                journal.SaveJournal();
            }

            if (choice == "5"){
                loopBreaker = true;
            }

       }
    }
}

}