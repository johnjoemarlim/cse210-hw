public class Comment
{
    private string _nameOfCommenter;
    private string _commentText;
    public Comment(string name, string text)
    {
        _nameOfCommenter = name;
        _commentText = text;
    }
    public void DisplayComment()
    {
        Console.Write($"{_nameOfCommenter} - ");
        Console.WriteLine($"'{_commentText}'");
    }
}