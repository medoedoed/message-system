using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class GroupAddressee : IAddressee
{
    private readonly List<IAddressee> _addressees;
    public GroupAddressee(IEnumerable<IAddressee> addressees)
    {
        _addressees = new List<IAddressee>(addressees);
    }

    public void SendMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        foreach (IAddressee addressee in _addressees)
        {
            addressee.SendMessage(message);
        }
    }
}