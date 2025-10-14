using Bogus;

static class StudentService
{
    static int count = 0;
    public static int Count => count;

    private static readonly Student?[] students = new Student[100];
    private static readonly string[] specializations =
    [
        "Software Engineering",
        "Computer Science",
        "Netwerk Engineering",
    ];

    public static Student? GetStudentByIndex(int index)
    {
        if (index < 0 || students.Length <= index)
        {
            return null;
        }

        return students[index];
    }

    public static bool AddStudent(Student student)
    {
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] == null)
            {
                students[i] = student;
                count++;
                return true;
            }
        }

        return false;
    }

    public static bool RemoveStudentByIndex(int index)
    {
        if (index < 0 || students.Length <= index)
        {
            return false;
        }

        students[index] = null;
        count--;
        return true;
    }

    public static Student CreateFakeStudent()
    {
        var faker = new Faker();
        return new Student
        {
            FirstName = faker.Name.FirstName(),
            LastName = faker.Name.LastName(),
            Specialization = faker.PickRandom(specializations),
        };
    }

    // TODO: Add create student factory method

    public static void AddMarksToStudent(int index, int subjectIndex, int mark)
    {
        if (index < 0 || students.Length <= index)
        {
            return;
        }

        if (subjectIndex < 0 || students[index]?.Marks.Length <= subjectIndex)
        {
            return;
        }

        if (students[index] == null)
        {
            return;
        }

        // TODO: Add validation for mark
        students[index]!.Marks[subjectIndex] = mark;
    }

    // TODO: Add Remove Mark
}
