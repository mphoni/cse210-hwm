using System;

namespace Foundation1
{
    public class Comment
    {
        public string _name;
        public string _text;

        public Comment()
        {

        }
        public void Display()
        {
            Console.WriteLine($"{_name} + {_text}");
        }
      
    }
}