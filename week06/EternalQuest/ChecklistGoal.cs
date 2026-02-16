public class ChecklistGoal : Goal
{
    //Attributes:
    //_amountCompleted (int)
    //_target (int)
    //_bonus (int)
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Methods:
    //RecordEvent
    //IsComplete()
    //GetDetailString()
    //GetStringRepresentation()

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted != _target)
        {
            return _points;
        }
        else
        {
            return _bonus;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted != _target)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public override string GetDetailString()
    {
        string completedList= "";
        for (int i = 0; i < _amountCompleted; i++)
        {
            completedList += "[X]";
        }
        int uncompleted = _target - _amountCompleted;
        for (int i = 0; i < uncompleted; i++)
        {
            completedList += "[ ]";
        }
        string detailedString = $"{completedList} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        return detailedString;
    }
     public override string GetStringRepresentation()
    {
        //To Save format
        return $"ChecklistGoal~{_shortName}~{_description}~{_points}~{_bonus}~{_target}~{_amountCompleted}";
    }
    public ChecklistGoal(string name, string description, int points, int bonus, int target, int completed) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }
}