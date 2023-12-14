using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.Comments.Add(new Comment("User1", "Comment 1 for video 1"));
        video1.Comments.Add(new Comment("User2", "Comment 2 for video 1"));
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.Comments.Add(new Comment("User3", "Comment 1 for video 2"));
        videos.Add(video2);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
