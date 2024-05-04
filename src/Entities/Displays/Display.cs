using System;
using System.Drawing;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays.Drivers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.EndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;

public class Display : IEndPoint
{
    private readonly Driver _driver;
    private string _messageBody = new(string.Empty);

    public Display(
        string name,
        ImportanceLevel level,
        Driver driver)
    {
        Name = name;
        Level = level;
        _driver = driver;
    }

    public ImportanceLevel Level { get; }
    public string Name { get; }

    public void DisplayMessage()
    {
        _driver.DisplayMessage(_messageBody);
    }

    public void SetColor(Color color)
    {
        _driver.SetColor(color);
    }

    public void GetMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        _messageBody = message.Body;
    }
}
