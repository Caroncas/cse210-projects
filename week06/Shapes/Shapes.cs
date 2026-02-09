public abstract class Shapes
{
    protected string _color;
    protected float _measurement;

    public string GetColor()
    {
        return _color;
    }
    public abstract double GetArea();
    public abstract string GetShapeType();
}