using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays.Drivers.Writers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays.Drivers;

public class Driver
{
    private readonly IWriter _writer;
    private Color _color;

    public Driver(IWriter writer)
    {
        _writer = writer;
    }

    public void SetColor(Color color)
    {
        _color = color;
    }

    public void Clear()
    {
        _writer.Clear();
    }

    public void DisplayMessage(string message)
    {
        Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(message);
        _writer.Write(message);
    }
}