using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "software engineer";
        job1._company = "microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "manager";
        job2._company = "apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //Console.WriteLine($"{job1._company} {job2._company}");
        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
