using System.ComponentModel;
using System.Runtime;

public abstract class Goal
{
    //Attributes:
    //_shortName (string)
    //_description (string)
    //_points (int) 
    protected string _shortName;
    protected string _description;
    protected int _points;

    //Methods: ABSTRACT
    //RecordEvent()
    //Is Complete()
    //GetDetailsString(text file)
    //GetStringRepresentation()
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailString();
    public abstract string GetStringRepresentation();
    public string GetStringName()
    {
        return _shortName;
    }
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
}