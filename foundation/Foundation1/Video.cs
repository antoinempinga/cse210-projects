using System;
public class Video

{
    private string _Title;
    private string _Author;
    private int _VideoLength;
    private List<Comment> _comments;
    

    public Video(string title, string author, int video )
    {
        _Title = title;
        _Author = author;
        _VideoLength = video;
        _comments = new List<Comment>();
    
    }
     public void AddComment(Comment comment)
   {
     _comments.Add(comment);
   }
     public int GetCommentCount()
    {
        return _comments.Count;
    }
    public void DisplayVideo()

    {
        Console.WriteLine($"Title: {_Title}");
        Console.WriteLine($"Author: {_Author}");
        Console.WriteLine($"Length: {_VideoLength} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($" - {comment.DisplayComment()}");
        }
        Console.WriteLine();
    }
        

}