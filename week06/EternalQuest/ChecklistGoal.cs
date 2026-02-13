public class ChecklistGoal : Goal
{
    //Attributes:
    //_amountCompleted (int)
    //_target (int)
    //_bonus (int)
    int _amountCompleted;
    int _target;
    int _bonus;

    //Methods:
    //RecordEvent
    //IsComplete()
    //GetDetailString()
    //GetStringRepresentation()

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
}