using System.Security.Cryptography;
using System.Xml.Serialization;

public abstract class Activity
{
    
    //Attributes:
    protected double _timeSpent;
    protected string _date;

    //Methods:
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        // Ex. 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0mph, Pace 10.0 min per mile
        return $"{_date} ({_timeSpent} min) - \nDistance {GetDistance():F1} miles \nSpeed {GetSpeed():F1} \nPace {GetPace():F1} minutes per mile";
    }

    public Activity(double time, string date)
    {
        _timeSpent = time;
        _date = date;        
    }
}