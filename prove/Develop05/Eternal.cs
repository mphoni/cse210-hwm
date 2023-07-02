using System;

namespace Develop5
{
    public class Eternal : Goals
    {
        public Eternal(string name, string description) : base(name, description)
        {
            Points = 10;
        
        }

        public override void Complete()
        {
            Points += 10;

             
        }
    }

}