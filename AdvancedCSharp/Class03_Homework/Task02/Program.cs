using Task02.models;
using Task02.Extensions;
namespace Task02;
internal class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car();
        Vehicle motorBike = new MotorBike();
        Vehicle boat = new Boat();
        Vehicle plane = new Airplane();

        car.DisplayInfo();
        car.Drive();

        motorBike.DisplayInfo();
        motorBike.Wheelie();

        boat.DisplayInfo();
        boat.Sail();

        plane.DisplayInfo();
        plane.Fly();

    }
}

/*
Create a class Vehicle that have one method DisplayInfo(). Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method
+
Task03 Also included into Task02
*/