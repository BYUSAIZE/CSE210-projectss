using System;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double _speed;

        public Cycling(DateTime date, int length, double speed)
            : base(date, length)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return (_speed * GetLength()) / 60;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60 / _speed;
        }

        public override string GetSummary()
        {
            return $"{GetDate():dd MMM yyyy} Cycling ({GetLength()} min) - " +
                   $"Distance {GetDistance():0.0} km, " +
                   $"Speed {GetSpeed():0.0} kph, " +
                   $"Pace: {GetPace():0.00} min per km";
        }
    }
}