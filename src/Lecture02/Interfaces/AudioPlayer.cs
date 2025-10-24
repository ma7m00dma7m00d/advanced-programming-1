using System;

namespace Lecture02.Interfaces
{
    public class AudioPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing audio");
        }
    }
}