using Task03_ShapeAbstractClasses.models;
namespace Task02_ShapeInterface.models;

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        double S = (SideA + SideB + SideC) / 2;
        return Math.Round(Math.Sqrt(S * (S - SideA) * (S - SideB) * (S - SideC)), 2);
    }

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
}