using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

public record Message
{
    public Message(
        string name,
        string body,
        ImportanceLevel level)
    {
        Name = name;
        Body = body;
        Level = level;
    }

    public Message(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        Name = message.Name;
        Body = message.Body;
        Level = message.Level;
    }

    public string Name { get; }
    public string Body { get; }
    public ImportanceLevel Level { get; }
}