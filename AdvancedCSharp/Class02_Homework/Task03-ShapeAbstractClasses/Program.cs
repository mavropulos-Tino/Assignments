using Task02_ShapeInterface.models;
using Task03_ShapeAbstractClasses.models;

namespace Class02_Homework;
class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle(5, 10),
            new Circle(4),
            new Triangle(6, 7, 8)
        };

        foreach (var shape in shapes)
        {
            shape.DisplayInfo();
        }
    }
}