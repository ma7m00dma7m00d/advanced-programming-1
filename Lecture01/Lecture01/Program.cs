namespace Lecture01;

public class Program
{
    private static void Main(string[] args)
    {
        PrintColored("Normal Car", ConsoleColor.Cyan);
        Car myCar = new Car();
        myCar.Start();
        myCar.Drive();

        // Inheritance
        PrintColored("Electric Car", ConsoleColor.Cyan);
        ElectricCar myElectricCar = new ElectricCar();
        myElectricCar.Start();
        myElectricCar.ChargeBattery();

        PrintColored("Electric Car as Normal Car", ConsoleColor.Cyan);
        Car electricCarAsCar = new ElectricCar();
        electricCarAsCar.Start();
        electricCarAsCar.Drive();

        // Polymorphism
        MIDIPlayer player1 = new MIDIPlayer();
        MIDIPlayer player2 = new VideoPlayer();

        PrintColored("MIDI Player", ConsoleColor.Cyan);
        player1.Play(); // MusicPlayer Play
        PrintColored("MIDI Player but it is a video player", ConsoleColor.Green);
        player2.Play(); // VideoPlayer Play

        // End of Polymorphism
        // End of Inheritance

        // Helper methods
        static void PrintColored(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

// Abstraction
abstract public class Vehicle
{
    public abstract void Start();
}

// Encapsulation
public class Car : Vehicle
{
    private string engineStatus = "off";

    public override void Start()
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

// Inheritance
public class ElectricCar : Car
{
    public void ChargeBattery()
    {
        Console.WriteLine("Battery is charging.");
    }
}

// Polymorphism
public class MIDIPlayer
{
    public virtual void Play()
    {
        Console.WriteLine("Playing music.");
    }
}

public class VideoPlayer : MIDIPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing video.");
    }
}
