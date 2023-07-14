using System;

namespace Foundation3{
    public abstract class Event{
        private string _title;
        private string _description;
        private string _date;
        private string _time;
        private Address address;

        public Event(string title, string date, string time, Address add){
            _title = title;
            _date = date;
            _time = time;
            address = add;
        }

        public string standardDetails(){
           string standard =  $"Title: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress:{address.getAddress()}";
           return standard;
        }
        
        public void setDescription(string des){
            _description = des;
        }

        public string getTilte(){
            return _title;
        }

        public string getDate(){
            return _date;
        }

        public abstract void shortDescription();
        public abstract void fullDetails();
    }
}