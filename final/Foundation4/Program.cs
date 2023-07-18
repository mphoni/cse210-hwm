using System;

namespace Foundation4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
        

            Running run1 = new Running(new DateTime(2023, 11, 3), 30, 3);
            activities.Add(run1);

            Cycling cycling1 = new Cycling(new DateTime(2024, 7, 20), 25, 5);
            activities.Add(cycling1);

            Swimming swimming1 = new Swimming(new DateTime(2022, 7, 24), 18, 4);
            activities.Add(swimming1);
        
            
        
            foreach (Activity a in activities)
            {
            Console.WriteLine(a.GetSummary());
            Console.WriteLine();
            }
        }


    }
}

