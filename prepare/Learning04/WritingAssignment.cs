using System;

namespace Learning04{
    public class WritingAssignment : Assignment{
        private string _title;
        public WritingAssignment(string name, string topic, string title) : base(name, topic){
            _title = title;
        }

        public string getWritingInfo(){
            string name = base.getName();
            string info = $"{_title} by {name}";
            return info;
        }
    }

}