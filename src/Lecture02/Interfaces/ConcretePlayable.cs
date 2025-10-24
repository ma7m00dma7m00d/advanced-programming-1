using System;

namespace Lecture02.Interfaces
{
    public class ConcretePlayable : AbstractPlayable
    {
        public override void Play()
        {
            Console.WriteLine("Playing from concrete class");
        }
    }
}