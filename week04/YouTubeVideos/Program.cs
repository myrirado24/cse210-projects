using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video("Introduction to C#", "CodeMaster", 1200);
        Video video2 = new Video("Advanced Python Techniques", "PyGuru", 1800);
        Video video3 = new Video("Web Development Basics", "WebDev Simplified", 900);
        Video video4 = new Video("Data Structures Explained", "AlgoKing", 1500);

        video1.AddComment(new Comment("Alice", "Great video, very clear explanations!"));
        video1.AddComment(new Comment("Bob", "Helped me understand abstract classes better."));
        video1.AddComment(new Comment("Charlie", "Can you make a video about LINQ?"));
        video1.AddComment(new Comment("David", "Excellent content for beginners."));

        video2.AddComment(new Comment("Eve", "The decorators section was mind-blowing!"));
        video2.AddComment(new Comment("Frank", "Learned so many new tricks."));
        video2.AddComment(new Comment("Grace", "Highly recommend this channel!"));

        video3.AddComment(new Comment("Heidi", "Perfect for getting started with HTML/CSS."));
        video3.AddComment(new Comment("Ivan", "Simple and easy to follow."));
        video3.AddComment(new Comment("Judy", "What about JavaScript next?"));

        video4.AddComment(new Comment("Kevin", "This video made recursion click for me."));
        video4.AddComment(new Comment("Liam", "Well-structured and comprehensive."));
        video4.AddComment(new Comment("Mia", "Please do more videos on algorithms!"));
        video4.AddComment(new Comment("Nora", "The visualizations were super helpful."));


        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        foreach (Video video in videos)
        {
            Console.WriteLine("---");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  - {comment._commenterName}: {comment._commentText}");
            }
            Console.WriteLine(); 
        }
    }
}