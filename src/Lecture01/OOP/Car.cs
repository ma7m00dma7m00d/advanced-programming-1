namespace Lecture01;

// Encapsulation
public class Car : Vehicle
{
    private string engineStatus = "off";

    public sealed override void Start()
    {
        engineStatus = "on";
        Console.WriteLine("Car engine is " + engineStatus);
    }

    public void Drive()
    {
        if (engineStatus == "on")
        {
            Console.WriteLine("Car is driving.");
        }
        else
        {
            Console.WriteLine("Start the car first.");
        }
    }
}
