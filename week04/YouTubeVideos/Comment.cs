public class Comment
{
    private string _name;
    private string _commentText;
    //Methods;
    public string PrintComment()
    {
        string commentString = _name + ": " + _commentText;
        return commentString;
    }
    //Constructors;
    public Comment(string name, string comment)
    {
        _name = name;
        _commentText = comment;
    }
}