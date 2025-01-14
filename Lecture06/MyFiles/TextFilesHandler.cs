namespace MyFiles;

public class TextFilesHandler
{
    public static void WriteOnTextFileUsingSteamWriter(string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, this is a test file!");
            writer.Write(writer.NewLine);
            writer.WriteLine("C# makes file handling easy.");
        }

        Console.WriteLine($"Data written to {filePath}");
    }

    public static void ReadFromTextFileUsingStreamReader(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (var reader = new StreamReader(filePath))
            {
                string? line;
                var _char = (char)reader.Read();
                if (_char != '\0')
                {
                    
                }
                line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }

            return;
        }

        Console.WriteLine("File not found.");
    }

    // TODO: Task: Read student names from "students.txt" and count them.

    public static void UpdateLogFile(string filePath)
    {
        using (var writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine($"{DateTime.Now}: User logged in.");
        }

        Console.WriteLine("Log updated.");
    }

    static void CountWordsFromFile(string filePath, string searchWord)
    {
        var count = 0;

        if (File.Exists(filePath))
        {
            using (var reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    count += line.ToLower().Contains(searchWord.ToLower()) ? 1 : 0;
                    // count += line.Split(' ').Count(word => word.Equals(searchWord, StringComparison.OrdinalIgnoreCase));
                }
            }

            Console.WriteLine($"The word '{searchWord}' appears {count} times.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public static void ReadFileWithExceptionHandling(string filePath)
    {
        try
        {
            using (var reader = new StreamReader(filePath))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}