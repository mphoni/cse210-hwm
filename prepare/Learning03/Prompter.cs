using System;
using System.Collections.Generic;

namespace Develop02
{

    public class Prompter
    {
        public string question;
        public string question1;
        public string question2;
        public string question3;
        public string question4;
        public List<Prompter> questions;
 
       public Prompter()
       {
            questions = new List<Prompter>();
       }

        public List<Prompter> GetQuestions()
        {
            return questions;
        }
        
        public void DisplayQuestions()
        {
            Console.WriteLine("What was the strongest emotion I felt today?");
                string question = Console.ReadLine();
        
            Console.WriteLine("If I had one thing I could do over today, what would it be?"); 
                string question1 = Console.ReadLine();

            Console.WriteLine("What was the best part of my day?");
                string question2 = Console.ReadLine();
            
            Console.WriteLine("How did I see the hand of the Lord in my life today?");
                string question3 = Console.ReadLine();
             
            Console.WriteLine("Who was the most interesting person I interacted with today?");
                 string question4 = Console.ReadLine();
        }
    }
}
