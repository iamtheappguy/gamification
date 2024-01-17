using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetDropUseCase;

public class GetDropRewardUseCaseRequest : ICommandRequest
{
    public string UserId { get; private set; }

    public GetDropRewardUseCaseRequest(string userId)
    {
        UserId = userId;
    }

}