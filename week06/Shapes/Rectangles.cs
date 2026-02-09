public class Rectancles : Shapes
{
    private double _width;
    public override double GetArea()
    {
        return _measurement * _width;
    }
    public override string GetShapeType()
    {
        return "rectangle";
    }
    public Rectancles(string color, float length, double width)
    {
        _color = color;
        _measurement = length;
        _width = width;
    }
}