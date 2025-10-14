static partial class ConsoleHelper
{
    public static void Print(string message)
    {
        Console.Write(message);
    }

    public static void PrintLine(string message)
    {
        Console.WriteLine(message);
    }

    public static void PrintLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintLine(char chr = '-')
    {
        Console.WriteLine(new string(chr, 40));
    }
}
