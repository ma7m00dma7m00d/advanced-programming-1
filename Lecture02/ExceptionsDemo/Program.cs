namespace ExceptionsDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = 0;
        try
        {
            var numberFromString = int.Parse("abc");
            var result = 10 / number;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        // OperationsDemo();
    }

    public static void OperationsDemo()
    {
        // Do list of operations
    }
}

public abstract class Operation()
{
    public abstract void Execute();
}

public class SingleParameterOperation // : Operation
{
    //
}

public class CoupleParameterOperation // : Operation
{
    //
}

// TODO: Build your own exceptions
