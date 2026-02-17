public class Running : Activity
{
    //Attributes:
    private double _distance;

    //Methods:
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _timeSpent * 60;
    }
    public override double GetPace()
    {
        return _timeSpent / _distance;
    }

    public Running(double time, string date, double distance) : base(time, date)
    {
        _distance = distance;
    }
}