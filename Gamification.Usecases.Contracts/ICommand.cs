namespace Gamification.UseCases.Contracts;

public interface ICommand<in TRequest, TResponse>
{
    public Task<TResponse> Call(TRequest data);
}