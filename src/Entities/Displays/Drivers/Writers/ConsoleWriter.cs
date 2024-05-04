using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays.Drivers.Writers;

public class ConsoleWriter : IWriter
{
    public void Write(string text)
    {
        Console.Clear();
        Console.Write(text);
    }

    public void Clear()
    {
        Console.Clear();
    }
}