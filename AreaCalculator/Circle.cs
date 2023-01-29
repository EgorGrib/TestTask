namespace AreaCalculator;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be a positive number");
        }
        _radius = radius;
    }

    public double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}