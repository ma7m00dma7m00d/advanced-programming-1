using System;

namespace Lecture02.Interfaces
{
    public class Car
    {
        private IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void StartCar()
        {
            _engine.Start();
            Console.WriteLine("Car started");
        }

        public void StopCar()
        {
            _engine.Stop();
            Console.WriteLine("Car stopped");
        }
    }
}