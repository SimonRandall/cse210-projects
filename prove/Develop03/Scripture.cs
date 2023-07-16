using System.Collections.Generic;
using System;

namespace Develop03
{
    ///The responsibility of the scripture class is to provide a string of the scripture.
    public class Scriptures{
        private List<string> _words;
        private string _scripture;

        public Scriptures(){
            _words = new List<string> {"For", "God", "so", "loved", "the", "world,", "that", "he", "gave", "his", "only", "begotten", "Son,", "that", "whosoever", "believeth", "in", "him", "should", "not", "perish", "but", "have", "everlasting", "life."};

        }
      public string GetScriptureString(){
            foreach (string word in _words){
                _scripture = _scripture + word + " ";
            }
            return _scripture;

       }
        public List<string> GetScriptureList(){
            return _words;
        }
    }
}