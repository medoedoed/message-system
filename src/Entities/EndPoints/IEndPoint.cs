using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.EndPoints;

public interface IEndPoint
{
    public ImportanceLevel Level { get; }
    public string Name { get; }
    void GetMessage(Message message);
}