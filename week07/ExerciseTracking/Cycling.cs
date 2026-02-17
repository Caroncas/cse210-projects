public class Cycling : Activity
{
    //Attributes:
    private double _speed;

    //Methods:
    public override double GetDistance()
    {
        return _speed / 60 * _timeSpent;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }

    public Cycling(double time, string date, double speed) : base(time, date)
    {
        _speed = speed;
    }
}