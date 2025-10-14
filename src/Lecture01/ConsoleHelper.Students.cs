using Bogus;

static partial class ConsoleHelper
{
    public static void PrintStudentsDemo()
    {
        var faker = new Faker();
        PrintLine("Welcome to the students demo!", ConsoleColor.Blue);
        PrintLine();

        PrintLine("Number of students: " + StudentService.Count);

        PrintLine("Addeding 10 students ...");
        for (int i = 0; i < 10; i++)
        {
            var student = StudentService.CreateFakeStudent();
            StudentService.AddStudent(student);
            StudentService.AddMarksToStudent(i, 0, faker.Random.Int(0, 10));
            StudentService.AddMarksToStudent(i, 1, faker.Random.Int(0, 10));
            StudentService.AddMarksToStudent(i, 2, faker.Random.Int(0, 10));
            StudentService.AddMarksToStudent(i, 3, faker.Random.Int(0, 10));
            PrintLine("Added student: " + student.FullName, ConsoleColor.Green);
        }

        PrintLine("Successfully Added 10 students", ConsoleColor.Green);
        PrintLine("Number of students: " + StudentService.Count);
        PrintLine();

        PrintLine();
        Console.WriteLine("All students:");
        for (int i = 0; i < StudentService.Count; i++)
        {
            var student = StudentService.GetStudentByIndex(i);
            PrintLine(student!.FullName, ConsoleColor.Cyan);
            PrintLine(student!.Specialization, ConsoleColor.Yellow);
            PrintLine();
            for (int j = 0; j < student.Marks.Length; j++)
            {
                Print($"Grade {j + 1}\t");
            }
            Print("\n");
            PrintLine();
            for (int j = 0; j < student.Marks.Length; j++)
            {
                Print($"      {student.Marks[j]}\t");
            }
            Print("\n");
            PrintLine('=');
        }
    }
}
