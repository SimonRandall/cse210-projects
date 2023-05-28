using System.Collections.Generic;
using System;

namespace Develop03
{
    ///The responsibility of the scripture class is to provide a string of the scripture.
    public class Word{

    public string Hide(List<string> words){
        int listLength = words.Count();
        Random rnd = new Random();
        int num = rnd.Next(0,listLength);
        int s = 0;
        bool loopBreaker = false;
        while (loopBreaker == false){
            if (words[num].Contains("_")){
                num = rnd.Next(0, listLength);
                 s = s + 1;
                if (s == words.Count()){
                    loopBreaker = true;
                }
            }
            if (!words[num].Contains("_")){
                loopBreaker = true;
            }
        }
        string word = words[num];
        int wordLength = word.Count();
        string underscore = "";
        for (int i = 0; i < wordLength; i++){
            underscore = underscore +"_";
        } 
        words.Insert(num, underscore);
        words.RemoveAt(num +1);
        string _scripture = "";
        foreach (string input in words){
            _scripture = _scripture + input + " ";
        }
        return _scripture;
        
    }
    }
}