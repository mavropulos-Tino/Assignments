using Task02.models;
namespace Task02.Extensions;
public static class VehicleExtension
{
    public static void Drive(this Vehicle car)
    {
        Console.WriteLine("The car is driving");
    }

    public static void Wheelie(this Vehicle motorBike)
    {
        Console.WriteLine("The motorbike is driving on one wheel");
    }

    public static void Sail(this Vehicle boat)
    {
        Console.WriteLine("The boat is sailing");
    }

    public static void Fly(this Vehicle airplane)
    {
        Console.WriteLine("The airplane is flying");
    }
}
