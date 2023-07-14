using System;

namespace Foundation4{
    public  abstract class Activity{
        private string _Date;
        private double _length;

        public Activity(string date, double len){
            _Date = date;
            _length = len;
        }

        public abstract double calcSpeed();
        public abstract double calcDistance();
        public abstract double calcPace();
        public abstract void getSummary();

        public double getLength(){
            return _length;
        }

        public string getDate(){
            return _Date;
        }

    }
}