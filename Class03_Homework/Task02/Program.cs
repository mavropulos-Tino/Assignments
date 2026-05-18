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
