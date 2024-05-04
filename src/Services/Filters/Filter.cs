using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.Filters;

public class Filter : IAddressee
{
    private readonly ImportanceLevel _level;
    private readonly IAddressee _addressee;

    public Filter(IAddressee addressee, ImportanceLevel level)
    {
        _addressee = addressee;
        _level = level;
    }

    public void SendMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        if (message.Level <= _level)
        {
            _addressee.SendMessage(message);
        }
    }
}