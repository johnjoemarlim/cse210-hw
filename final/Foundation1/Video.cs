using System.Globalization;

public class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title;
    private string _author;
    private int _length;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public int GetNumberOfComments()
    {
        int numberOfComments = _comments.Count();
        return numberOfComments;
    }
    public void AddComment(string name, string comment)
    {
        Comment c1 = new Comment(name, comment);
        _comments.Add(c1);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        
        Console.WriteLine("Comments: ");
        // Comment comment = new Comment()
        int number = 1;

        foreach (Comment comment in _comments)
        {
            
            Console.Write($"    {number}. ");
            comment.DisplayComment();
            number += 1;
        }
        Console.WriteLine();
    }
    
}