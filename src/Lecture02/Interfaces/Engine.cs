using System;

namespace Lecture02.Interfaces
{
    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine starting");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopping");
        }
    }
}