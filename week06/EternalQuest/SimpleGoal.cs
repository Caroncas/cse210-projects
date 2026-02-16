using System.ComponentModel;
using System.Net.NetworkInformation;

public class SimpleGoal : Goal
{
    //Attributes:
    //_isComplete (bool)
    private bool _isComplete;

    //Methods:
    //RecordEvent
    //IsComplete()
    //GetStringRepresentation()
    public override int RecordEvent()
    {
        _isComplete = true;
        return 0;
    }
    public override bool IsComplete()
    {
        bool completed;
        if (_isComplete == true)
        {
            completed = true;
        }
        else
        {
            completed = false;
        }
        return completed;
    }
    public override string GetDetailString()
    {
        bool completed = IsComplete();
        string detailedString;
        if (completed == true)
        {
            detailedString = $"[X] {_shortName} ({_description})";
        }
        else
        {
            detailedString = $"[ ] {_shortName} ({_description})";
        }
        return detailedString;
    }
    public override string GetStringRepresentation()
    {
        //To Save format
        return $"SimpleGoal~{_shortName}~{_description}~{_points}~{_isComplete}";
    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

}