using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.EndPoints;

public class User : IEndPoint
{
    private Dictionary<Message, bool> _receiviedMessages = new Dictionary<Message, bool>();

    public User(string name, ImportanceLevel level)
    {
        Name = name;
        Level = level;
    }

    public string Name { get; }

    public ImportanceLevel Level { get; }

    public void GetMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        _receiviedMessages.Add(message, false);
    }

    public void ReadMessage(Message message)
    {
        if (_receiviedMessages[message] == true) throw new ArgumentException("Message already read!");
        _receiviedMessages[message] = true;
    }

    public bool CheckMessage(Message message)
    {
        return _receiviedMessages[message];
    }
}