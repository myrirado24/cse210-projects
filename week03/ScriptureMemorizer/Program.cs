using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Mosiah", 2, 41), "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end, they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.")
        };

        Random random = new Random();
        int randomIndex = random.Next(0, scriptureLibrary.Count);
        Scripture currentScripture = scriptureLibrary[randomIndex];

        string userInput = "";

        while (userInput.ToLower() != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                currentScripture.HideRandomWords(random.Next(3, 6));
            }
        }

        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayText());
        Console.WriteLine("\nProgram ended. Good luck with your memorization!");
        Console.WriteLine("Press any key to close the window.");
        Console.ReadKey();
    }
}