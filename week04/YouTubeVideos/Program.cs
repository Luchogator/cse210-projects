using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video1 = new Video("C# Basics", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));

        Video video2 = new Video("OOP in C#", "Jane Smith", 900);
        video2.AddComment(new Comment("Charlie", "Clear explanations!"));
        video2.AddComment(new Comment("Dana", "This made OOP easy to understand."));

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
