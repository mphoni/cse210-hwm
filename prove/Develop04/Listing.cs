using System;

namespace Develop04
{
    public class Listing : Activities
    {
        private string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public Listing(int duration)
        {
            this.duration = duration;
            this.name = "Listing";
        }

        public override string GetDescription()
        {
            return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        public void StartListingActivity()
        {
            StartActivity();

            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            Pause(2);
            Console.WriteLine("Start listing:");

            int count = 0;
            string input;
            do
            {
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                    count++;
            } while (!string.IsNullOrEmpty(input) && count < duration);

            Console.WriteLine($"Number of items listed: {count}");

            EndActivity();
        }
    }
}
