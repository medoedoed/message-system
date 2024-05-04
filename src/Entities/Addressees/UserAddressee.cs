using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.EndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class UserAddressee : IAddressee
{
    private readonly User _user;

    public UserAddressee(User user)
    {
        _user = user;
    }

    public void SendMessage(Message message)
    {
        ArgumentNullException.ThrowIfNull(message);
        _user.GetMessage(message);
    }
}
