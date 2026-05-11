using Task03_ShapeAbstractClasses.models;
namespace Task02_ShapeInterface.models;
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
    }

    public override double CalculatePerimeter()
    {
        return Math.Round(2 * Math.PI * Radius, 2);
    }
}