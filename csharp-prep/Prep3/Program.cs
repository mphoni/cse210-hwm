using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
      
          
          
        //while (guess != magicNumber)
        {
          Console.WriteLine("what is your guess?");
          //int guess = int.Parse(Console.ReadLine());

          Console.WriteLine("what is your magic number?");
          //int magicNumber = int.Parse(Console.ReadLine());

        
          //if( guess > magicNumber ) 
          {
            Console.WriteLine("higher");
          }
          //else if(guess < magicNumber)
          {
            Console.WriteLine("lower");
          }
          else
          { 
            Console.WriteLine("you guessed it");
          }

          Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            // We could also use a do-while loop here...
            while (guess != magicNumber)
            {
              Console.Write("What is your guess? ");
              guess = int.Parse(Console.ReadLine());

              if (magicNumber > guess)
              {
                Console.WriteLine("Higher");
              }
              else if (magicNumber < guess)
              {
                Console.WriteLine("Lower");
              }
              else
              {
                Console.WriteLine("You guessed it!");
              }
            }
        } 
    }
}
