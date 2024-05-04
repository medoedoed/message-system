using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays.Drivers.Writers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.Logger;

public class Logger : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly IWriter _writer;

    public Logger(IAddressee addressee, IWriter writer)
    {
        _addressee = addressee;
        _writer = writer;
    }

    public void SendMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);

        _writer.Write("Message send: " + message.Name);
        _addressee.SendMessage(message);
    }
}
