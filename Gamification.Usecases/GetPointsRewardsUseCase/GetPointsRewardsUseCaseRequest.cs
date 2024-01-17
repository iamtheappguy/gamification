using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetPointsRewardsUseCase;

public class GetPointsRewardsUseCaseRequest : ICommandRequest
{
    public string UserId { get; private set; }

    public GetPointsRewardsUseCaseRequest(string userId)
    {
        UserId = userId;
    }
}