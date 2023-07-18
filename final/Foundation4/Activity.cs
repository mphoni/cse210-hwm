using System;

namespace Foundation4
{
    public  abstract class Activity
    {
        private int minutes;
        private DateTime date;


        public Activity( DateTime date, int minutes)
        {
            
            this.date = date;
            this.minutes = minutes;
        }

        public virtual double GetDistance()
        {
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            return 0.0;
        }

        public virtual double GetPace()
        {
            return 0.0;
        }

        public virtual string GetSummary()
        {
            return $"{date.ToString("dd MMM yyy")} {GetType().Name} ({minutes} min) - " + 
            $"Distance: {GetDistance()} km, Speed: {GetSpeed()}km/h Pace: {GetPace()} min/km";
        }
        
    }
}