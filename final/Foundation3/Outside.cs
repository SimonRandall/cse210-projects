using System;

namespace Foundation3{
    public class Outside : Event{
        private string weather;

        public Outside(string title, string description, string date, string time, Address add, string _weather) : base(title, date, time, add){
            base.setDescription(description);
            weather = _weather;
        }

        public override void shortDescription(){
            string description = $"Outside : {base.getTilte()} : {base.getDate()}";
            Console.WriteLine(description);
        }

        public override void fullDetails(){
            string details = $"{base.standardDetails()}\nWeather Info: {weather}";
            Console.WriteLine(details);
        }


    }


}