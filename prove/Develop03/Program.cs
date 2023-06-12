using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Learning05 World!");
        
            Loader loader = new Loader("dictionary.csv");
            Scripture scripture = new Scripture(loader.FindRandomScripture());
            Console.Clear();

            while (scripture.hiddenWords != scripture.totalWords)
            {

                Console.WriteLine(loader.reference + " " + scripture.AsString());
                Console.WriteLine();
                Console.WriteLine("Press P to hide a word.");
                Console.WriteLine("Press O to reveal the last word.");
                Console.WriteLine("Type 'quit' to exit.");
                string keyEnter = Console.ReadLine();
                    
                if (keyEnter.ToLower() == "p")
                {
                    scripture.HideRandomWord();
                    Console.Clear();
                }
                    
                else if (keyEnter.ToLower() == "o")
                {
                    scripture.ShowLastHiddenWord();
                    Console.Clear();
                }
                    
                else if (keyEnter.ToLower() == "quit")
                {
                    break;
                }
                    

                    
                else 
                {
                Console.Clear();
                Console.WriteLine("Please enter P, O, or 'quit'.");
                Console.WriteLine();
                }
            }
                Console.Clear();
                Console.WriteLine(loader.reference + " " + scripture.AsString());
                Console.WriteLine();
                Console.WriteLine("Press any key to terminate program.");
                Console.ReadLine();

        
        }
    }
}
