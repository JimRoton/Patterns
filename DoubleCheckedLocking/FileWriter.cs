namespace DoubleCheckedLocking;

using System.IO;

public class FileWriter
{
    // A public property to store the file path
    public string FilePath { get; set; }

    // A constructor that takes the file path as a parameter
    public FileWriter(string filePath)
    {
        FilePath = filePath;
    }

    // A method that writes a string to the file
    public void Write(string text)
    {
        // Use the File.WriteAllText method to write the text to the file
        File.WriteAllText(FilePath, text);
    }
}
