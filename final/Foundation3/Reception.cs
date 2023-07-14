using System;

namespace Foundation3{
    public class Reception : Event{
        private string email;

        public Reception(string title, string description, string date, string time, Address add, string _email) : base(title, date, time, add){
            base.setDescription(description);
            email = _email;
        }

        public override void shortDescription(){
            string description = $"Reception : {base.getTilte()} : {base.getDate()}";
            Console.WriteLine(description);
        }

        public override void fullDetails(){
            string details = $"{base.standardDetails()}\nRSPV: {email}";
            Console.WriteLine(details);
        }


    }


}