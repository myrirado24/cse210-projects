using System;

public class Job
{
    public string _jobTitle;
    public string _company;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company})");
    }
}