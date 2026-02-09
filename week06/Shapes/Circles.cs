public class Circles : Shapes
{
    public double _pi = 3.14;
    public override double GetArea()
    {
        return _measurement * _measurement * _pi;
    }
    public override string GetShapeType()
    {
        return "circle";
    }
    public Circles(string color, float radius)
    {
        _color = color;
        _measurement = radius;
    }
}