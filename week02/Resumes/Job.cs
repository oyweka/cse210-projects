using System;

public class Job
{
    public string _jobTitle;
    public string _organization;
    public string _department;
    public string _years;

    public Job()
    {

    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_organization}) in {_department} department - Salary ({_years})");
    }
}

