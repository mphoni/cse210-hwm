using System;

namespace Foundation3
{
    public class Outdoor : Event
    {
        private string Weather{get; set;}

        public Outdoor (string eventTitle, string type, string Description, DateTime date, TimeSpan time, string weather) :base( eventTitle, type,  Description, date, time)
        {
            Weather = weather;
        }

          public override string GetStandardMessage()
        {
            return $"Title of Event: {EventTitle} Description: {Description} Date: {Date} Time: {Time} Address: {_location}";
        }

           public override string GetFullMessage()
        {
            return $"Title of Event: {EventTitle} Description: {Description} Date: {Date} Time: {Time} Address: {_location} Weather Statement: {Weather}";
        }

         public override string GetShortMessage()
        {
            return $"Type of Event: {Type}: {EventTitle} on {Date}";
        }

        public override string GetEventsDetails()
        {
            return $"Weather {EventTitle}";
        }

    }
}