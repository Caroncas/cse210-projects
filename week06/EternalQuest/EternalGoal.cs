public class EternalGoal : Goal
{
    //Attributes:
    //NONNEEEEEE yay
    private int _completedCounter;

    //Methods:
    //RecordEvent
    //IsComplete()
    //GetStringRepresentation()
    public override int RecordEvent()
    {
        _completedCounter++;
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailString()
    {
        bool completed = IsComplete();
        string detailedString;
        if (_completedCounter == 0)
        {
            detailedString = $"[ ] {_shortName} ({_description})";
        }
        else if (_completedCounter == 1)
        {
            detailedString = $"[ ] {_shortName} ({_description}) -- You have completed this goal {_completedCounter} time";
        }
        else
        {
            detailedString = $"[ ] {_shortName} ({_description}) -- You have completed this goal {_completedCounter} times";
        }
        return detailedString;
    }
     public override string GetStringRepresentation()
    {
        //To Save format
        return $"EternalGoal~{_shortName}~{_description}~{_points}~{_completedCounter}";
    }
    public EternalGoal(string name, string description, int points, int counter) : base(name, description, points)
    {
        _completedCounter = counter;
    }
}