namespace GenericsDemo;

public class Program
{
    private static void Main(string[] args)
    {
        GenericDemo();
        // Then try this
        // GenericArrayDemo();

        // TODO: Try add generic interfaces
    }

    public static void GenericDemo()
    {
        // Without generics
        BasicHelpers.Print(5);
        BasicHelpers.Print(5.0);
        BasicHelpers.Print(10_000_000_000);
        BasicHelpers.Print("This is a string");

        var intVariable = BasicHelpers.Return(5);
        var doubleVariable = BasicHelpers.Return(10_000_000_000);
        var stringVariable = BasicHelpers.Return("this is a string");

        // With generics
        GenericHelpers.Print(5); // this equals BasicHelpers.Print<int>(5)
        GenericHelpers.Print<double>(5.0);
        GenericHelpers.Print<string>("this is a string");
        GenericHelpers.Print<char>('d');

        intVariable = GenericHelpers.Return(5);
        doubleVariable = GenericHelpers.Return(10_000_000_000);
        stringVariable = GenericHelpers.Return("this is a string");
    }

    private static void GenericArrayDemo()
    {
        // Try other type
        GenericArray<int?> array = new GenericArray<int?>(5);
        array.Add(1);
        array.Add(2);
        array.Add(3);
        array.Add(4);
        array.Add(5);
        array.Add(6);
        array.Add(7);
        array.Add(8);
        array.Add(9);
        array.Add(10);

        Console.Write($"[array({array.LastAdded, 4})]: ");
        array.Print();
        array.DeleteAt(5);
        Console.Write($"[array({array.LastAdded, 4})]: ");
        array.Print();
    }
}
