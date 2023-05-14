using System;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Learning04 World!");

            Entry myEntry = new Entry();
            myEntry.Store("What is your name?","mfoniso martin", "8 may 2023");

            Journal journal1 = new Journal();
            journal1.StoreEntry(myEntry);

        

            List<Entry> entries = journal1.GetAllEntries();
            foreach(Entry entry in entries)
            {
                string message = entry.GetAsString();
                Console.WriteLine(message);
            }

            Prompter prompt1 = new Prompter();
            prompt1.Display();
            prompt1.DisplayQuestions();
            
            Prompts prompt = new Prompts();
            prompt.DisplayQuestions();
            prompt.DisplayQuestion();


        }
    }
}
