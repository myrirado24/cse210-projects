using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("There will not be a newline after this");

        Console.Write("What is yout favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your color is " + color);

        // Start of assignment
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}