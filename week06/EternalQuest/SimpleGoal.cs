using System.ComponentModel;

public class SimpleGoal : Goal
{
    //Attributes:
    //_isComplete (bool)
    bool _isComplete;

    //Methods:
    //RecordEvent
    //IsComplete()
    //GetStringRepresentation()

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

}