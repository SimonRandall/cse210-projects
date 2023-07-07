using System.Collections.Generic;
using System;
using System.IO;

namespace Develop02
{
    ///The responsibility of a Journal is to hold entries
    public class Journal{
        public List<Entry> entries;
        public Journal(){
            entries = new List<Entry>();
        }
        public void SaveJournal(){
            Console.WriteLine("Where do you want to save your entries?");
            string filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
            foreach (Entry input in entries){
                string date = input.GetDate();
                string prompt = input.GetPrompt();
                string response = input.GetResponse();
                outputFile.WriteLine($"{date}:{prompt}:{response}");
            }
            }

        }

        public void AddEntry(Entry name){
            entries.Add(name);
        }

        public void LoadJournal(){
            Console.WriteLine("Where do you want to load entries from?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines){
                Entry load = new Entry();
                string[] parts = line.Split(":");
                load.SetEntry(parts[1], parts[2], parts[0]);
                entries.Add(load);
            }
        }

        public void DisplayJournal(){
            foreach (Entry input in entries){
                string date = input.GetDate();
                string prompt = input.GetPrompt();
                string response = input.GetResponse();
                Console.WriteLine($"{date}--{prompt}: {response}");
            }

        }
    }
}