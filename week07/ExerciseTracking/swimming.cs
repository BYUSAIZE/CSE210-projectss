using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int length, int laps)
            : base(date, length)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return (_laps * 50.0) / 1000;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / GetLength()) * 60;
        }

        public override double GetPace()
        {
            return GetLength() / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{GetDate():dd MMM yyyy} Swimming ({GetLength()} min) - " +
                   $"Distance {GetDistance():0.0} km, " +
                   $"Speed {GetSpeed():0.0} kph, " +
                   $"Pace: {GetPace():0.00} min per km";
        }
    }
}