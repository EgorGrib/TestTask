using AreaCalculator;

namespace Tests;

public class Tests
{
    [Test]
    public void Creating_Circle_With_Radius_0()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
    
    [Test]
    public void Calculating_Area_Of_Circle_With_Radius_1()
    {
        var circle = new Circle(1);
        Assert.That(circle.GetArea(), Is.EqualTo(3.141592653589793));
    }
    
    [Test]
    public void Calculating_Area_Of_Circle_With_Radius_235()
    {
        var circle = new Circle(235);
        Assert.That(circle.GetArea(), Is.EqualTo(173494.45429449633));
    }
    
    [Test]
    public void Creating_Circle_With_Radius_Minus_5()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-5));
    }
    
    [Test]
    public void Creating_Triangle_With_Sides_Minus_3_4_5()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
    }
    
    [Test]
    public void Creating_Triangle_With_Sides_1_2_5()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
    }
    
    [Test]
    public void Calculating_Area_Of_Triangle_With_Sides_3_4_5()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.GetArea(), Is.EqualTo(6));
    }
    
    [Test]
    public void Calculating_Area_Of_Triangle_With_Sides_20_12_30()
    {
        var triangle = new Triangle(20, 12, 30);
        Assert.That(triangle.GetArea(), Is.EqualTo(80.492235650402947));
    }
    
    [Test]
    public void Is_Right_Triangle_With_Sides_3_4_5()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsRight, Is.EqualTo(true));
    }
    
    [Test]
    public void Is_Right_Triangle_With_Sides_3_4_6()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.That(triangle.IsRight, Is.EqualTo(false));
    }
}