using Task02_ShapeInterface.interfaces;
using Task02_ShapeInterface.models;

namespace Class02_Homework;
class Program
{
    static void Main(string[] args)
    {
        IShape[] shapes = new IShape[]
        {
            new Rectangle("Rectangle", 10, 5),
            new Circle("Circle", 4),
            new Triangle("Triangle", 7, 6)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.Name} has the area of: {shape.getArea()}");
        }
    }
}