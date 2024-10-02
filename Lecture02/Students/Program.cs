namespace Students;

public class Program
{
    private static void Main(string[] args)
    {
        Student student1 = new SoftwareStudent();
        student1.Id = 1;
        student1.Name = "Mahmoud";
        Student student2 = new NetworkingStudent();
        student2.Id = 2;
        student2.Name = "Ali Mahmoud";
        Student student3 = new ComputersStudent();
        student3.Id = 3;
        student3.Name = "Mohammad Mahmoud";
        student3.Documents = new Document[]
        {
            new PaperDocument { Name = "Doc1" },
            new EDocument { Name = "Doc2" }
        };

        Student[] students = new Student[] { student1, student2, student3 };

        foreach (Student item in students)
        {
            if (item is ComputersStudent)
            {
                Console.Write("Info: Computers Student:");
            }
            
            Console.WriteLine(item.ToString());
            item.GetCertificate();
        }

        foreach (var item in student3.Documents)
        {
            item.Print();
        }
        // TODO: Create list of students (software, networking, and computers) (done)
        // TODO: Print list of students (done)
        // TODO: Print list of certificate
        // TODO: Sort list of students (choose metric)

        // TODO: Choose Student and print all hist documents
    }
}

public abstract class Document
{
    public string Name { get; set; }

    public string Content { get; set; }

    public abstract void Print();
}

public class PaperDocument : Document
{
    public override void Print()
    {
        Console.WriteLine("Paper Document");
        Console.WriteLine(Name + " " + Content);
    }
}

public class EDocument : Document
{
    public override void Print()
    {
        Console.WriteLine("Electronic Document");
        Console.WriteLine(Name + " " + Content);
    }
}

public class Student
{
    public Document[] Documents { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return Id + ": " + Name;
    }

    public virtual void GetCertificate()
    {
        Console.WriteLine("Student Certificate");
    }
}

public class SoftwareStudent : Student
{
    public override void GetCertificate()
    {
        Console.WriteLine("Software Student Certificate");
    }
}

public class NetworkingStudent : Student
{
    public override void GetCertificate()
    {
        Console.WriteLine("Networking Student Certificate");
    }
}

public class ComputersStudent : Student
{
    //
}
