namespace test;

using test.myextentions;
using System;

class Program
{
    static void Main(string[] args)
    {
        //----------------------------------------------------
        // Testing integer extension methods
        //----------------------------------------------------
        System.Console.WriteLine( "Enter an integer number:");
        int number = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"{number} is even: {MyExtentions.IsEven(number)}");
        Console.WriteLine($"{number} is odd: {number.IsOdd()}");
        Console.WriteLine($"{number} is prime: {number.IsPrime()}");
        number.Increment(); // use of ref extension method
        Console.WriteLine($"Incremented: {number}");


        //----------------------------------------------------
        // Testing Point struct and distance calculations
        //----------------------------------------------------
        Point[] points ={
            new Point(0,0),
            new Point(3,4),
            new Point(6,8),
            new Point(10,10)
        };

        double totalDistance;
        var distances = CalculateDistances(points, out totalDistance);

        var geoSummary = new
        {
            totalPointsCnt = points.Length,
            points,
            distances,
            totalDistance
        };

        DisplaySummary(geoSummary.points, geoSummary.distances, geoSummary.totalDistance, geoSummary.totalPointsCnt);
    }

    static double[] CalculateDistances(Point[] points,out double totalDistance)
    {
        var distances = new double[points.Length - 1];
        totalDistance = 0;
        for (int i = 0; i < distances.Length; i++)
        {
            distances[i] = points[i].DistanceBetween(points[i + 1]);
            totalDistance += distances[i];
        }
        return distances;
    }

    static void DisplaySummary(Point[] points, double[] distances, double totalDistance, int totalPoints)
    {
        System.Console.WriteLine("============================");
        Console.WriteLine("=== GEOMETRY SUMMARY ===");
        Console.WriteLine($"Total Points: {totalPoints}");
        Console.WriteLine($"Total Distance: {totalDistance:F2}");

        Console.WriteLine("\nPoints:");
        for (int i = 0; i < points.Length; i++)
        {
            Console.WriteLine($"  Point {i + 1}: {points[i]}");
        }

        Console.WriteLine("\nDistances between consecutive points:");
        for (int i = 0; i < distances.Length; i++)
        {
            Console.WriteLine($"  From {points[i]} to {points[i + 1]}: {distances[i]:F2}");
        }
    }
}