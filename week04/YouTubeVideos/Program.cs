using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("The best F1 drivers", "Speed at limit", 700);
        video1.AddComment("F1 enjoyer", "Max Verstappen is the best!");
        video1.AddComment("TheRealDriver32", "I agree with your video");
        video1.AddComment("Jona", "Wow, the're really good");

        Video video2 = new Video("The best valorant teams for 2025", "Shooting Stars fps", 900);
        video2.AddComment("FireFly", "Kru is so good but I think that Fanatic is better");
        video2.AddComment("Julio", "Maybe TH can win this year");
        video2.AddComment("TL fan", "I belive in Team Liquid this year, they have a solid team with Nats and Patitek");

        Video video3 = new Video("Why be an introvert isn't bad?", "Psydude", 850);
        video3.AddComment("camille", "Is good to see more people like me in the comments");
        video3.AddComment("Marcus", "I wasn't aware of how amazing I was thanks you");
        video3.AddComment("Lettuce 897", "Could you make a video about some mental health?");

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details for each video
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
