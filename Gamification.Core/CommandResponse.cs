using Gamification.Interfaces.UseCases;

namespace Gamification.Core;

public class CommandResponse<T> : ICommandResponseData<T>
{
    public CommandResponse(bool success, T data)
    {
        Success = success;
        Data = data;
    }

    public bool Success { get; }

    public T Data { get; }
}