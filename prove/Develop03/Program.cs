using System;

namespace Develop03;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scriptures script = new Scriptures();
        Reference name = new Reference();
        string verseName = name.GetReference() +" ";
        string initial_verse = script.GetScriptureString();
        Console.Write(verseName);
        Console.WriteLine(initial_verse);
        Console.WriteLine("Press Enter to delete words, or Space to end program");
        List<string> verse = script.GetScriptureList();


        bool loopBreaker = false;

        while(loopBreaker == false){

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            
            if (keyInfo.Key == ConsoleKey.Enter){
                Word new_verse = new Word();
                Console.Clear();
                Random rnd = new Random();
                int wordsLost = rnd.Next(1,3);
                int counter = 0;
                while(wordsLost != counter){
                    Console.Clear();
                    Console.Write(verseName);
                    Console.WriteLine(new_verse.Hide(verse));
                    Console.WriteLine("Press Enter to delete words, or Space to end program");
                    counter = counter +1;
                }
            }
            
            if(keyInfo.Key == ConsoleKey.Spacebar){
                loopBreaker = true;
            }

        }


    }
}