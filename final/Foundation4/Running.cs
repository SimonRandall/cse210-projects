using System;

namespace Foundation4{
    public class Running : Activity{
        private double _distance;

        public Running(string date, double length, double distance): base(date,length){
            _distance = distance;
        }

        public override double calcDistance()
        {
            return _distance;
        }

        public override double calcSpeed()
        {
            double speed = (_distance / base.getLength()) * 60;
            return speed;
        }

        public override double calcPace()
        {
            double pace = base.getLength() / _distance;
            return pace;
        }

        public override void getSummary()
        {
            Console.WriteLine($"{base.getDate()} Running- Distance {_distance} miles, Speed {this.calcSpeed()} mph, Pace {this.calcPace()} minutes per mile");
        }
    }

}