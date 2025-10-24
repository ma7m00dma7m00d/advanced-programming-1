using System;

namespace Lecture02.Interfaces
{
    public class VideoPlayer : IPlayable, IRecordable
    {
        // Implicit implementation
        public void Play()
        {
            Console.WriteLine("Playing video");
        }

        // Explicit implementation
        void IRecordable.Record()
        {
            Console.WriteLine("Recording video");
        }
    }
}