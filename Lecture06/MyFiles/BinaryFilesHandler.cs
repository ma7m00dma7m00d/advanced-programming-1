namespace MyFiles;

public class BinaryFilesHandler
{
    public static void WriteToBinaryFile(string filePath)
    {
        using (var writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(1); // ID
            writer.Write("John Doe"); // Name
            writer.Write(25); // Age
        }

        Console.WriteLine("Data written to binary file.");
    }
    
    public static void ReadFromBinaryFile(string filePath)
    {
        using (var reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            var id = reader.ReadInt32();
            var name = reader.ReadString();
            var age = reader.ReadInt32();
            
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }
    }
    
    // TODO: Task: Create a program to store product data (ID, name, and price) in a binary file and then retrieve it.
}