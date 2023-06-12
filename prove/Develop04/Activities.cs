using System;
using System.Threading;

namespace Develop04
{
    public class Activities
    {
        protected int duration;
        protected string name;

        public void StartActivity()
        {
            Console.WriteLine($"Starting {name} activity...");
            Console.WriteLine($"Description: {GetDescription()}");
            Console.WriteLine($"Duration: {duration} seconds");

            Pause(2);
            Console.WriteLine("Prepare to begin...");
            Pause(2);
        }

        public virtual string GetDescription()
        {
            return "";
        }

        protected void Pause(int seconds)
        {
            for (int i = seconds; i > 0; i++)
            {
                Console.Write($"{i}...");
                Thread.Sleep(1000);
            }
            Console.WriteLine();

          
        }

        

        public void EndActivity()
        {
            Console.WriteLine("Great job!");
            Console.WriteLine($"You have completed the {name} activity.");
            Console.WriteLine($"Duration: {duration} seconds");

            Pause(2);
        }
    }
}
