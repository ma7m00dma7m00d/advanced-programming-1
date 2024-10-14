namespace GenericsDemo;

// Without generics
public class BasicHelpers
{
    public static void Print(int input)
    {
        Console.WriteLine(input);
    }

    public static void Print(long input)
    {
        Console.WriteLine(input);
    }

    public static void Print(double input)
    {
        Console.WriteLine(input);
    }

    public static void Print(string input)
    {
        Console.WriteLine(input);
    }

    public static int Return(int value)
    {
        return value;
    }

    public static double Return(double value)
    {
        return value;
    }

    public static string Return(string value)
    {
        return value;
    }
}
