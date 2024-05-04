using System;
using System.IO;
using System.Text;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays.Drivers.Writers;

public class FileWriter : IWriter
{
    private readonly string _filePath;

    public FileWriter(string filePath)
    {
        _filePath = filePath;
    }

    public void Write(string text)
    {
        ArgumentNullException.ThrowIfNull(text);
        var fileStream = new FileStream(_filePath, FileMode.Create);
        fileStream.Write(Encoding.Default.GetBytes(text), 0, text.Length);
        fileStream.Close();
    }

    public void Clear()
    {
        var fileStream = new FileStream(_filePath, FileMode.Create);
        fileStream.Close();
    }
}