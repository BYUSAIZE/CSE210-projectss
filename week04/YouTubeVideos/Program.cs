using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 20 Minutes", "Code Academy", 1200);
        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("John", "Easy to understand."));
        video1.AddComment(new Comment("Mary", "Great tutorial."));
        videos.Add(video1);

        Video video2 = new Video("White Water Rafting Adventure", "Adventure Hub", 850);
        video2.AddComment(new Comment("Peter", "Looks exciting!"));
        video2.AddComment(new Comment("Grace", "I want to try this."));
        video2.AddComment(new Comment("Sam", "Amazing scenery."));
        videos.Add(video2);

        Video video3 = new Video("Top 10 Football Goals", "Sports World", 980);
        video3.AddComment(new Comment("David", "Goal #3 was incredible."));
        video3.AddComment(new Comment("Chris", "Awesome video."));
        video3.AddComment(new Comment("Mike", "Thanks for sharing."));
        videos.Add(video3);

        Video video4 = new Video("Cooking Homemade Pizza", "Kitchen Pro", 1500);
        video4.AddComment(new Comment("Sarah", "Looks delicious."));
        video4.AddComment(new Comment("Emma", "I'll try this recipe."));
        video4.AddComment(new Comment("Daniel", "Simple and easy."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}