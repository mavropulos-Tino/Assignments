using Task02_ShapeInterface.interfaces;
namespace Task02_ShapeInterface.models;
public class Rectangle : IShape
{
    public string Name { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string name, double width, double height)
    {
        Name= name;
        Width= width;
        Height = height;
    }

    public double getArea()
    {
        return Width * Height;
    }
}