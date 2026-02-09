public class Squares : Shapes
{
    public override double GetArea()
    {
        return _measurement * _measurement;
    }

    public override string GetShapeType()
    {
        return "square";
    }
    public Squares(string color, float side)
    {
        _color = color;
        _measurement = side;
    }
}