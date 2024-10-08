namespace Interfaces;

public class Program
{
    private static void Main(string[] args)
    {
        Document document = new Document();
        document.Print();
        document.Print("Doc1");
        document.Print("Doc1", 20);
        document.SetName("Testing");
        Console.WriteLine(document.Name);

        Person person = new Person();
        person.Print();

        SetName(person);
        Print(person);

        SetName(document);
        Print(document);

        static void Print(IPrintable obj)
        {
            obj.Print();
        }

        static void SetName(ISetName obj)
        {
            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            if (name == null)
                return;
            obj.SetName(name);
        }
    }
}

public interface ISetName
{
    string Name { get; }

    void SetName(string name);
}

public interface IPrintable
{
    void Print();
    void Print(string name);
    void Print(string name, int age);
}

class Document : IPrintable, ISetName
{
    private string? name;
    public string? Name
    {
        get { return "Mr. " + name; }
    }

    public int MyProperty { get; set; }

    public void Print()
    {
        Console.WriteLine($"My name is {name} and I am Document");
    }

    public void Print(string name)
    {
        Console.WriteLine("Document name: " + name);
    }

    public void Print(string name, int age)
    {
        Console.WriteLine("Document name: " + name + ", age: " + age);
    }

    public void SetName(string name)
    {
        this.name = name;
    }
}

class Person : IPrintable, ISetName
{
    private string? name;
    public string? Name
    {
        get { return name; }
    }

    public void Print()
    {
        Console.WriteLine($"I am Person with name {name}");
    }

    public void Print(string name)
    {
        Console.WriteLine("Person name: " + name);
    }

    public void Print(string name, int age)
    {
        Console.WriteLine("Person name: " + name + ", age: " + age);
    }

    public void SetName(string name)
    {
        this.name = name;
    }
}
