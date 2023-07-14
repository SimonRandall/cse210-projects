using System;

namespace Foundation4{
    public class Swimming : Activity{
        private double _laps;

        public Swimming(string date, double length, double laps): base(date,length){
            _laps = laps;
        }

        public override double calcDistance()
        {
            double distance = _laps * 50 / 1000 *.62;
            return distance;
        }

        public override double calcSpeed()
        {
            double speed = ((_laps * 50 / 1000 *.62) / base.getLength()) * 60;
            return speed;
        }

        public override double calcPace()
        {
            double pace = base.getLength() / (_laps * 50 / 1000 *.62);
            return pace;
        }

        public override void getSummary()
        {
            Console.WriteLine($"{base.getDate()} Running- Distance {this.calcDistance()} miles, Speed {this.calcSpeed()} mph, Pace {this.calcPace()} minutes per mile");
        }
    }

}