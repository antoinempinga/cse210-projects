using System;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C#", "Ethan", 600);
        Video video2 = new Video("Mastering ASP.NET", "Craig", 1200);
        Video video3 = new Video("Data Structures Simplified", "Alex", 900);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Thanks for the tutorial."));
        video1.AddComment(new Comment("Charlie", "Clear and concise."));

        video2.AddComment(new Comment("Diana", "This was very helpful."));
        video2.AddComment(new Comment("Eve", "Could you cover more examples?"));
        video2.AddComment(new Comment("Frank", "Awesome video!"));

        video3.AddComment(new Comment("Grace", "Loved the visuals!"));
        video3.AddComment(new Comment("Heidi", "Nice breakdown of the topic."));
        video3.AddComment(new Comment("Ivan", "Could you add more animations?"));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

       
        foreach (var video in videos)
        {
            video.DisplayVideo();
        }
    }
}