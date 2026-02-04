public class MathAssignment : Assignment
{
    //Attributes:
    private string _textbookSection;
    private string _problems;

    //Methods:
    public string GetHomeworkList()
    {
        string listOfProblems = $"{_textbookSection} Problems: {_problems}";
        return listOfProblems;
    }

    //Constructors:
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }
}