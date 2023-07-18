using System;

namespace Foundation3
{
    public class Lecture : Event
    {
        private string Speaker{get; set;}
        private int Capacity{get; set;}

        public Lecture(string eventTitle, string type, string Description, DateTime date, TimeSpan time, string speaker, int capacity) :base( eventTitle, type,  Description, date, time)
        {
            Speaker = speaker;
            Capacity = capacity;
        }


          public override string GetStandardMessage()
        {
            return $"Title of Event: {EventTitle} Description: {Description} Date: {Date} Time: {Time} Address: {_location}";
        }

           public override string GetFullMessage()
        {
            return $"Title of Event: {EventTitle} Description: {Description} Date: {Date} Time: {Time} Address: {_location} Type: {Type} Speaker{Speaker} Capacity{Capacity}";
        }

         public override string GetShortMessage()
        {
            return $"Type of Event: {Type}: {EventTitle} on {Date}";
        }

        public override string GetEventsDetails()
        {
            return $"Name of Event: {EventTitle}";
        }

    }

}











        