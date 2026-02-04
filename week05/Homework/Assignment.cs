public class Assignment
{
    //Attributes:
    protected string _studentName;
    private string _topic;

    //Methods:
    public string GetSummary()
    {
        string summary = $"{_studentName} | {_topic}";
        return summary;
    }

    //Constructors:
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
}