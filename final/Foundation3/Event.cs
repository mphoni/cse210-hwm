using System;

namespace Foundation3
{
    public abstract class Event
    {
        protected string EventTitle{get; set;}
        protected string Description{get; set;}
        protected DateTime Date{get; set;}
        protected TimeSpan Time{get; set;}
        public string Type{get; set;}
        protected Address _location;

        public Event( string eventTitle, string type, string description, DateTime date, TimeSpan time)
        {
            EventTitle = eventTitle;
            Description = description;
            Date = date;
            Time = time;
            Type = type;
            
        }

        public abstract string GetStandardMessage();

        public abstract string GetFullMessage();
        public abstract string GetShortMessage();

        public virtual string GetEventsDetails()
        {
            return "";
        }
    }
}