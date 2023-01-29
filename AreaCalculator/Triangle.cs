namespace AreaCalculator;

public class Triangle : IFigure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            throw new ArgumentException("A side of a triangle cannot be less than 0");
        }
        _a = a;
        _b = b;
        _c = c;

        if(!IsValidTriangle(a, b, c))
        {
            throw new ArgumentException("The sum of the two sides of a triangle must always be greater than the third side");
        }
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        var maxEdge = Math.Max(a, Math.Max(b, c));
        var perimeter = a + b + c;
        return !(perimeter-(maxEdge+maxEdge) <= 0);
    }
    
    public double GetArea()
    {
        var halfPerimeter = (_a + _b + _c) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - _a) * (halfPerimeter - _b) * (halfPerimeter - _c));
    }

    public bool IsRight()
    {
        const double tolerance = 0.00001;
        if (Math.Abs(_a * _a - (_b * _b + _c * _c)) < tolerance) return true;
        if (Math.Abs(_b * _b - (_a * _a + _c * _c)) < tolerance) return true;
        return Math.Abs(_c * _c - (_a * _a + _b * _b)) < tolerance;
    }
}