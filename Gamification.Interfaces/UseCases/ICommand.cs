namespace Gamification.Interfaces.UseCases;

public interface ICommand<in TRequest, TResponse>
{
    public Task<TResponse> Call(TRequest data);
}