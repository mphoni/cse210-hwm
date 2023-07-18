using System;

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Foundation3 World!");

            Lecture lecture = new Lecture("Science Talks", "Lecture", "Use of Science", new DateTime(2023, 07, 24), new TimeSpan(1, 30, 15), "John Murray", 1000);

            Reception reception= new Reception("Kathy weds Johhny", "Reception", " Wedding", new DateTime(2023, 9, 1), new TimeSpan(1, 30, 15), "KatandJohn@gmail.com");

            Outdoor outdoor= new Outdoor("Ben&Laurie's Naming", "outdoor", "Baby Shower", new DateTime(2023, 10, 31),new TimeSpan(1, 30, 15), "It is sunny today");

            Event[] events = { lecture, reception, outdoor};

            foreach (Event e in events)
            {
                Console.WriteLine($"Event name: {e.GetEventsDetails()}");
                Console.WriteLine($"Standard message: {e.GetStandardMessage()}");
                Console.WriteLine($"Full message: {e.GetFullMessage()}");
                Console.WriteLine($"Short message: {e.GetShortMessage()}");
                Console.WriteLine();
            }

        }
    }
    }
