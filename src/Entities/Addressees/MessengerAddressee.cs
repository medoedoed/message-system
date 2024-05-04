using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class MessengerAddressee : IAddressee
{
    private readonly IMessenger _messenger;

    public MessengerAddressee(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void SendMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        _messenger.GetMessage(message);
    }
}