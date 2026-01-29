using System.Reflection.Metadata;

public class Video
{
    //Attributes;
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();
    //Methods;
    public void GetComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumberOfComments()
    {
        int commentCount = _comments.Count();
        return commentCount;
    }
    public void DisplayInformation()
    {
        Console.WriteLine($"{_title} - {_author} ({_length} seconds)");
        int number = NumberOfComments();
        Console.WriteLine($"{number} comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.PrintComment());  
        }
    }   
    //Constructors;
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
}