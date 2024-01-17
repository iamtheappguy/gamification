namespace Gamification.UseCases.Contracts;

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