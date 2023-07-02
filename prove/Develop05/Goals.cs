using System;

namespace Develop5
{
    public abstract class Goals
    {
        public  string Name {get;}
        public string Description {get;}
        public int Points {get; protected set;}
        public bool Completed  {get; protected set;}


    public Goals(string name, string description)
    {
        Name = name;
        Description = description;
        Points = 0;
        Completed = false;
    
    }

    public abstract void Complete();
    }
}