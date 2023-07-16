using System;

namespace Learning04{
    public class Assignment{
        private string _studentName;
        private string _topic;

        public Assignment(string name, string topic){
            _studentName = name;
            _topic = topic;
        }

        public string getSummary(){
            string sum = $"{_studentName} - {_topic}";
            return sum;
        }

        public string getName(){
            return _studentName;
        }
    }


}