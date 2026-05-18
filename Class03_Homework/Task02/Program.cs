using Task02.models;
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
        motorBike.DisplayInfo();
        boat.DisplayInfo();
        plane.DisplayInfo();
    }
}

/*
Create a class Vehicle that have one method DisplayInfo(). Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method
*/