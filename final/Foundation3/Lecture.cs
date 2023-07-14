using System;

namespace Foundation3{
    public class Lecture : Event{
        private string speaker;
        private int capacity;

        public Lecture(string title, string description, string date, string time, Address add, string _speaker, int number) : base(title, date, time, add){
            base.setDescription(description);
            speaker = _speaker;
            capacity = number;
        }

        public override void shortDescription(){
            string description = $"Lecture : {base.getTilte()} : {base.getDate()}";
            Console.WriteLine(description);
        }

        public override void fullDetails(){
            string details = $"{base.standardDetails()}\nSpeaker: {speaker} \nCapacity: {capacity}";
            Console.WriteLine(details);
        }


    }


}