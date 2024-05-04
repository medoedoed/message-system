using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;

public class Messenger : IMessenger
{
    public Messenger(string name, ImportanceLevel level)
    {
        Name = name;
        Level = level;
    }

    public string MessageBody { get; private set; } = new(string.Empty);

    public ImportanceLevel Level { get; }
    public string Name { get; }

    public void GetMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        MessageBody = message.Body;
    }

    public void DisplayMessage()
    {
        Console.WriteLine(MessageBody);
    }
}