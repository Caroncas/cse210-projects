public class Swimming : Activity
{
    //Attributes:
    private int _numberOfLaps;

    //Methods:
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        double distance = GetDistance();
        return distance / _timeSpent * 60;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return _timeSpent / distance;
    }

    public Swimming(double time, string date, int laps) : base(time, date)
    {
        _numberOfLaps = laps;
    }
}