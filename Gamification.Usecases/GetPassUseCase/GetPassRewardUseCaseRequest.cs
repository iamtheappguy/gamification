using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetPassUseCase;

public class GetPassRewardUseCaseRequest : ICommandRequest
{
    public string UserId { get; private set; }

    public GetPassRewardUseCaseRequest(string userId)
    {
        UserId = userId;
    }

}