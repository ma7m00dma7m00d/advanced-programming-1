using Lecture07.Generics;
using Lecture07.Regex;
using System;

namespace Lecture07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----- Running Regex Lab -----");
            RegexExercises.RunValidation();
            RegexExercises.RunLogParsing();
            RegexExercises.RunRedaction();

            Console.WriteLine("\n----- Running Generics Lab -----");
            GenericsDemo.Run();

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}