namespace GenericsDemo;

public class GenericHelpers
{
    public static void Print<T>(T input)
    {
        Console.WriteLine(input);
    }

    // TODO: Try add method with two type parameters

    public static T Return<T>(T input)
    {
        return input;
    }
}
