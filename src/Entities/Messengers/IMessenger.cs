using Itmo.ObjectOrientedProgramming.Lab3.Entities.EndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;

public interface IMessenger : IEndPoint
{
    void DisplayMessage();
}