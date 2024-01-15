namespace Gamification.Repositories.Contracts;

public class RepositoryResponse<T>
{
    public bool Success { get; }
    public string Message { get; }
    public T Data { get; }

    public RepositoryResponse(bool success, string message, T data)
    {
        Success = success;
        Message = message;
        Data = data;
    }
}