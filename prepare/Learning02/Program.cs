using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 1998;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 1999;
        job2._endYear = 2006;

        Resume resume1 = new Resume();
        resume1._name = "Juan Campos";
        resume1._Jobs.Add(job1);
        resume1._Jobs.Add(job2);
        resume1.DisplayResume();


    }
}