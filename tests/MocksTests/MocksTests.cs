using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays.Drivers.Writers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.EndPoints;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Filters;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Logger;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.MocksTests;

public class MocksTests
{
    [Fact]
    public void MessageFilterDoesNotReceived()
    {
        IAddressee addressee = Substitute.For<IAddressee>();
        var filter = new Filter(addressee, ImportanceLevel.Level1);
        var topic = new Topic("topic", filter);
        var message = new Message("asd", "asd", ImportanceLevel.Level2);
        topic.SendMessage(message);
        addressee.DidNotReceive().SendMessage(message);
    }

    [Fact]
    public void LoggerReturnOneMessage()
    {
        IWriter writer = Substitute.For<IWriter>();
        var addressee = new UserAddressee(new User("name", ImportanceLevel.Level1));
        var logger = new Logger(addressee, writer);
        var topic = new Topic("topic", logger);
        var message = new Message("asd", "asd", ImportanceLevel.Level1);
        topic.SendMessage(message);

        writer.Received(1).Write(Arg.Any<string>());
    }

    [Fact]
    public void MessengerReceivesMessagePrintsExpected()
    {
        IWriter writer = Substitute.For<IWriter>();
        int counter = 0;
        var message = new Message("a", "a", ImportanceLevel.Level3);
        var messenger = new Messenger("mes", ImportanceLevel.Level3);
        var addressee = new MessengerAddressee(messenger);
        var logger = new Logger(addressee, writer);
        var topic = new Topic("b", logger);

        writer
            .When(x => x.Write("Message send: a"))
            .Do(_ => counter++);
        topic.SendMessage(message);

        Assert.Equal(1, counter);
        Assert.Equal("a", messenger.MessageBody);
    }
}