using System;

namespace Lecture02.Interfaces
{
    public abstract class AbstractPlayable : IPlayable
    {
        public abstract void Play();
        public void Pause()
        {
            Console.WriteLine("Pausing");
        }
    }
}