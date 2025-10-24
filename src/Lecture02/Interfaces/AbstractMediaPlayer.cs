using System;

namespace Lecture02.Interfaces
{
    public abstract class AbstractMediaPlayer
    {
        public abstract void Play();
        public void Stop()
        {
            Console.WriteLine("Stopping media");
        }
    }
}