using System;

namespace Develop5
{
    public class Checklist : Goals
    {
        public int itemCount {get;}
        public int CompletedCount{get; set;}

        public Checklist(string name, string description, int itemsCount) : base(name, description)
        {
            itemCount = itemsCount;
            CompletedCount = 0;
        }

        public override void Complete()
        {
            CompletedCount ++;
        }
    }
}