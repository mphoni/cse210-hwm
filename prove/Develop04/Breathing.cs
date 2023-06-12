using System;

namespace Develop04
{
    public class Breathing : Activities
    {
        public Breathing(int duration)
        {
            this.duration = duration;
            this.name = "Breathing";
        }
        

        public override string GetDescription()
        {
            return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public void StartBreathingActivity()
        {
            StartActivity();

            for (int i = 1; i <= duration; i++)
            {
                Console.WriteLine("Breathe in...");
                Pause(2);
                Console.WriteLine("Breathe out...");
                Pause(2);
            }

            EndActivity();
        }
    }
}

