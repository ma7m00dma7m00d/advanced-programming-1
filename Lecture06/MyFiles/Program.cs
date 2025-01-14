using System.Text.Json;

namespace MyFiles;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Files Lecture");
        Console.Write("Enter a file path: ");
        var filePath = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filePath))
        {
            Console.WriteLine("Path can't be null or white space");
        }

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File is not exists!");
            Console.WriteLine("Exiting..");
            return;
        }

        var fileInfo = new FileInfo(filePath);
        Console.WriteLine($"File Name: {fileInfo.Name}");
        Console.WriteLine($"File Length (bytes): {fileInfo.Length}");
        Console.WriteLine($"File DirectoryName: {fileInfo.DirectoryName}");
        Console.WriteLine($"File CreationTime: {fileInfo.CreationTime}");
        Console.WriteLine($"File LastAccessTime: {fileInfo.LastAccessTime}");
        Console.WriteLine($"File LastWriteTime: {fileInfo.LastWriteTime}");
        Console.WriteLine($"File Attributes: {JsonSerializer.Serialize(fileInfo.Attributes)}");
    }

    public static void CopyFile(string sourcePath, string destinationPath)
    {
        if (File.Exists(sourcePath))
        {
            File.Copy(sourcePath, destinationPath, overwrite: true);
            Console.WriteLine("File copied successfully.");
        }
        else
        {
            Console.WriteLine("Source file not found.");
        }
    }
}