using Task02_ShapeInterface.interfaces;
namespace Task02_ShapeInterface.models;

public class Triangle : IShape
{
    public string Name { get; set; }
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(string name, double @base, double height)
    {
        Name = name;
        Base = @base;
        Height = height;
    }
    public double getArea()
    {
        return 0.5 * Base * Height;
    }
}