using Lecture01;

static partial class ConsoleHelper
{
    public static void PrintOOPDemo()
    {
        PrintLine('*');
        PrintLine("Welcome to the students demo!", ConsoleColor.Blue);
        PrintLine('*');

        PrintLine("Normal Car", ConsoleColor.Cyan);
        Car myCar = new Car();
        myCar.Start();
        myCar.Drive();

        // Inheritance
        PrintLine("Electric Car", ConsoleColor.Cyan);
        ElectricCar myElectricCar = new ElectricCar();
        myElectricCar.Start();
        myElectricCar.ChargeBattery();

        PrintLine("Electric Car as Normal Car", ConsoleColor.Cyan);
        Car electricCarAsCar = new ElectricCar();
        electricCarAsCar.Start();
        electricCarAsCar.Drive();

        // Polymorphism
        MIDIPlayer player1 = new MIDIPlayer();
        MIDIPlayer player2 = new VideoPlayer();

        PrintLine("MIDI Player", ConsoleColor.Cyan);
        player1.Play(); // MusicPlayer Play
        PrintLine("MIDI Player but it is a video player", ConsoleColor.Green);
        player2.Play(); // VideoPlayer Play

        // End of Polymorphism
        // End of Inheritance
    }
}
