using Task02_ShapeInterface.interfaces;
namespace Task02_ShapeInterface.models;

public class Circle : IShape
{
    public string Name { get; set; }
    public double Radius { get; set; }

    public Circle(string name, double radius)
    {
        Name = name;
        Radius = radius;
    }

    public double getArea()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
    }
}