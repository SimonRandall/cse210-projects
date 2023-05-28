using System.Collections.Generic;
using System;

namespace Develop03
{
    ///The responsibility of the scripture class is to provide a string of the scripture.
    public class Scriptures{
        private List<string> _words;
        private string _scripture;

        public Scriptures(){
            _words = new List<string> {"For", "God","So","loved","the","world","that","he","gave","his","only","begotten","Son","that","whosoever"};
            _words.Add("beleiveth");
            _words.Add("in");
            _words.Add("him");
            _words.Add("should");
            _words.Add("not");
            _words.Add("perish");
            _words.Add("but");
            _words.Add("have");
            _words.Add("everlasting");
            _words.Add("life");
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