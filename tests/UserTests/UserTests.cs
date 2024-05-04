using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.EndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;
using Itmo.ObjectOrientedProgramming.Lab3.Tests.UserTests.UserTestDataGenerators;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.UserTests;

public class UserTests
{
    [Theory]
    [ClassData(typeof(UserTestDataGenerator))]
    public void MessageUnreadWhenSend(
        Message message,
        User user,
        Topic topic)
    {
        ArgumentNullException.ThrowIfNull(user);
        ArgumentNullException.ThrowIfNull(topic);

        topic.SendMessage(message);
        Assert.False(user.CheckMessage(message));
    }

    [Theory]
    [ClassData(typeof(UserTestDataGenerator))]
    public void MessageBecomeReadAfterReading(
        Message message,
        User user,
        Topic topic)
    {
        ArgumentNullException.ThrowIfNull(user);
        ArgumentNullException.ThrowIfNull(topic);

        topic.SendMessage(message);

        Assert.False(user.CheckMessage(message));

        user.ReadMessage(message);

        Assert.True(user.CheckMessage(message));
    }

    [Theory]
    [ClassData(typeof(UserTestDataGenerator))]
    public void ReturnExceptionWhenMessageAlreadyRead(
        Message message,
        User user,
        Topic topic)
    {
        ArgumentNullException.ThrowIfNull(user);
        ArgumentNullException.ThrowIfNull(topic);

        topic.SendMessage(message);

        user.ReadMessage(message);

        Exception? exception = Record.Exception(() =>
        {
            user.ReadMessage(message);
        });

        Assert.NotNull(exception);
    }
}