namespace Lecture01;

// Inheritance
sealed public class ElectricCar : Car
{
    public void ChargeBattery()
    {
        Console.WriteLine("Battery is charging.");
    }
}
