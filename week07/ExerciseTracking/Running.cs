using System;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double _distance;

        public Running(DateTime date, int length, double distance)
            : base(date, length)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / GetLength()) * 60;
        }

        public override double GetPace()
        {
            return GetLength() / _distance;
        }

        public override string GetSummary()
        {
            return $"{GetDate():dd MMM yyyy} Running ({GetLength()} min) - " +
                   $"Distance {GetDistance():0.0} km, " +
                   $"Speed {GetSpeed():0.0} kph, " +
                   $"Pace: {GetPace():0.00} min per km";
        }
    }
}