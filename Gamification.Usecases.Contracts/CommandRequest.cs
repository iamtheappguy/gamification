
namespace Gamification.UseCases.Contracts;

public class CommandRequest<T> :  ICommandRequest
{
    public CommandRequest(T data)
    {
        Data = data;
    }
    public T Data { get; }
}