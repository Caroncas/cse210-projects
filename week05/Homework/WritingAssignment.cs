public class WritingAssignment : Assignment
{
    //Attributes:
    private string _title;

    //Methods:
    public string GetWritingInfo()
    {
        string assignmentInfo = $"{_title} by {_studentName}";
        return assignmentInfo;
    }

    //Constructors:
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
}