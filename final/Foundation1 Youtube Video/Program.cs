using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("Commenter A", "Interesting video!");
        video1.AddComment("Commenter B", "I enjoyed it!");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("Commenter C", "Great content!");
        videos.Add(video2);

        foreach(var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
