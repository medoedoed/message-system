using System.Collections;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.EndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.UserTests.UserTestDataGenerators;

public class UserTestDataGenerator : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        var user = new User("user", ImportanceLevel.Level1);
        var topic = new Topic("topic", new UserAddressee(user));
        var message = new Message("header", "body", ImportanceLevel.Level1);
        yield return new object[]
        {
            message,
            user,
            topic,
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}