using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class DisplayAddressee : IAddressee
{
    private readonly Display _display;

    public DisplayAddressee(Display display)
    {
        _display = display;
    }

    public void SendMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        _display.GetMessage(message);
    }
}