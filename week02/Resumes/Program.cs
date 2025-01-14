using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._jobTitle =  "Game Design";
        job2._company = "Riot Games";
        job2._startYear = 2023;
        job2._endYear = 2025;

        job1.Display();

        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "William Moncada";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}