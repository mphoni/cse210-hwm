using System;

namespace Develop5
{
    public class Simple : Goals
    {
        public Simple(string name, string description) : base(name, description)
        {
            Points = 50;
        }

        public override void Complete()
        {
            if(!Completed)
            {
                Completed = true;
            }
        }
    }
}

    
