using System; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";

        Console.WriteLine($"Job 1 Title: {job1._jobTitle}");
        Console.WriteLine($"Job 1 Company: {job1._company}");

        Job job2 = new Job();

        job2._jobTitle = "Manager";
        job2._company = "Apple";

        Console.WriteLine($"Job 1 Title: {job2._jobTitle}");
        Console.WriteLine($"Job 1 Company: {job2._company}");
    }
}