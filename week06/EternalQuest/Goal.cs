public abstract class Goal
{
    //Attributes:
    //_shortName (string)
    //_description (string)
    //_points (int) 
    string _shortName;
    string _description;
    int _points;

    //Methods: ABSTRACT
    //RecordEvent ()
    //Is Complete
    //GetDetailsString(text file)
    //GetStringRepresentation()

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
}