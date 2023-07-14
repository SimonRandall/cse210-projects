using System;

namespace Foundation4{
    public class Cycling : Activity{
        private double _speed;

        public Cycling(string date, double length, double speed): base(date,length){
            _speed = speed;
        }

        public override double calcDistance()
        {
            double distance = (_speed/60) * base.getLength();
            return distance;
        }

        public override double calcSpeed()
        {
            return _speed;
        }

        public override double calcPace()
        {
            double pace = base.getLength() / ((_speed/60) * base.getLength());
            return pace;
        }

        public override void getSummary()
        {
            Console.WriteLine($"{base.getDate()} Cycling- Distance {this.calcDistance()} miles, Speed {_speed} mph, Pace {this.calcPace()} minutes per mile");
        }
    }

}