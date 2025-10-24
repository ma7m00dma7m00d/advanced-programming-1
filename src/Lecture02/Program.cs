using Lecture02.Interfaces;

Console.WriteLine("=== Lecture 02: Interfaces Demo ===\n");

// 1. Interfaces vs Abstract Classes
Console.WriteLine("1. Interfaces vs Abstract Classes:");
Console.WriteLine("   - Interface: Contract that classes must implement");
Console.WriteLine("   - Abstract Class: Can provide default implementations\n");

// 2. Interfaces with Abstract Classes
Console.WriteLine("2. Interfaces with Abstract Classes:");
AbstractPlayable abstractPlayer = new ConcretePlayable();
abstractPlayer.Play(); // Implemented in concrete class
abstractPlayer.Pause(); // Default implementation from abstract class
Console.WriteLine();

// 3. Implicit and Explicit Implementation
Console.WriteLine("3. Implicit and Explicit Implementation:");
VideoPlayer videoPlayer = new VideoPlayer();
videoPlayer.Play(); // Implicit implementation

// Explicit implementation - only accessible through interface
IRecordable recordable = videoPlayer;
recordable.Record(); // Explicit implementation
Console.WriteLine();

// 4. Composition over Inheritance
Console.WriteLine("4. Composition over Inheritance:");
IEngine engine = new Engine();
Car car = new Car(engine); // Composition: Car has an Engine
car.StartCar();
car.StopCar();
Console.WriteLine();

// Additional examples
Console.WriteLine("Additional Interface Examples:");
IPlayable audioPlayer = new AudioPlayer();
audioPlayer.Play();

IPlayable anotherVideoPlayer = new VideoPlayer();
anotherVideoPlayer.Play();
