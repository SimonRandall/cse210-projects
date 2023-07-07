using System.Collections.Generic;
using System;

namespace Develop03
{
    ///The responsibility of the scripture class is to provide a string of the scripture.
    public class Scriptures{
        private List<string> _words;
        private string _scripture;

        public Scriptures(){
            _words = new List<string> {"In", "the", "premortal", "realm", "spirit", "sons", "and", "daughters", "knew", "and", "worshipped", "God", "as", "their", "Eternal", "Father", "and", "accepted", "His", "plan", "by", "which", "His", "children", "could", "obtain", "a", "physical", "body", "and", "gain", "earthly", "experience", "to", "progress", "toward", "perfection", "and", "ultimately", "realize", "their", "divine", "destiny", "as", "heirs", "of", "eternal", "life", "The", "divine", "plan", "of", "happiness", "enables", "family", "relationships", "to", "be", "perpetuated", "beyond", "the", "grave", "Sacred", "ordinances", "and", "covenants", "available", "in", "holy", "temples", "make", "it", "possible", "for", "individuals", "to", "return", "to", "the", "presence", "of", "God", "and", "for", "families", "to", "be", "united", "eternally",};

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