using System;

namespace Foundation3
{
   
    public class Address : Event
    {
        private string Location{get; set;}

        public Address(string eventTitle, string type, string Description, DateTime date, TimeSpan time, string location) :base( eventTitle, type,  Description, date, time)
        {
            Location = location; 
        }
        
          public override string GetStandardMessage()
        {
            return $"Title of Event: {EventTitle} Description: {Description} Date: {Date} Time: {Time} Address: {_location}";
        }

           public override string GetFullMessage()
        {
            return $"Title of Event: {EventTitle} Description: {Description} Date: {Date} Time: {Time} Address: {_location}";
        }

         public override string GetShortMessage()
        {
            return $"Type of Event: {Type}: {EventTitle} on {Date}";
        }

        public override string GetEventsDetails()
        {
            return $"Location: {Location}";
        }

    }
}