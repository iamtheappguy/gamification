using Gamification.Interfaces;

namespace Gamification.UseCases.GetPointsRewardsUseCase;

public class GetPointsRewardsUseCaseRequest : ICommandRequest
{
    public string UserId { get; private set; }

    public GetPointsRewardsUseCaseRequest(string userId)
    {
        UserId = userId;
        UserId = userId;
    }

}