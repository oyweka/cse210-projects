using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._organization = "Microsoft";
        job1._department = "Business & Enterprise";
        job1._years = "2017 - 2019";

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._organization = "Facebook";
        job2._department = "Business & Enterprise";
        job2._years = "2019 - 2026";

        Resume resume = new Resume();
        resume._name = "Alex Ochieng Oyweka";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResumeDetails();
    }
}