using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learning C#", "John Doe", 600);
        Video video2 = new Video("Cooking Pasta", "Jane Smith", 300);
        Video video3 = new Video("Travel Vlog: Paris", "Emily Johnson", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "Yummy recipe!"));
        video2.AddComment(new Comment("Eve", "Can't wait to try this."));
        video2.AddComment(new Comment("Frank", "Looks delicious!"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Beautiful city!"));
        video3.AddComment(new Comment("Heidi", "I want to visit Paris now."));
        video3.AddComment(new Comment("Ivan", "Great vlog!"));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
