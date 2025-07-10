using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job = new Job();
        job._company = "Microsoft";
        job._jobTitle = "Software Engineer";
        job._startYear = 2020;
        job._endYear = 2024;
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Web Designer";
        job2._startYear = 2010;
        job2._endYear = 2020;
        Resume resume = new Resume();
        resume._name = "Christian Nataren Laguna";
        resume._jobs.Add(job2);
        resume._jobs.Add(job);

        resume.Display();
    }
}