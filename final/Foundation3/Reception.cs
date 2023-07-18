using System;

namespace Foundation3
{
    public class Reception : Event 
    {
        private string Email{get;   set;}

        public Reception(string eventTitle, string type, string Description, DateTime date, TimeSpan time, string email) :base( eventTitle, type,  Description, date, time)
        {
            Email = email;
        }

          public override string GetStandardMessage()
        {
            return $"Title of Event: {EventTitle} Description: {Description} Date: {Date} Time: {Time} Address: {_location}";
        }

           public override string GetFullMessage()
        {
            return $"Title of Event: {EventTitle} Description: {Description} Date: {Date} Time: {Time} Address: {_location} Email: {Email}";
        }

         public override string GetShortMessage()
        {
            return $"Type of Event: {Type}: {EventTitle} on {Date}";
        }

            public override string GetEventsDetails()
        {
            return $"{EventTitle}";
        }

    }
}