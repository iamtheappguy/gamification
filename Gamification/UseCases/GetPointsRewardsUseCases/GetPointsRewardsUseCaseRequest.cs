using Gamification.Core;
using Gamification.Interfaces;

namespace Gamification.UseCases.GetPointsRewardsUseCases;

public class GetPointsRewardsUseCaseRequest : ICommandRequest
{
    public string UserId { get; private set; }

    public GetPointsRewardsUseCaseRequest(string userId)
    {
        UserId = userId;
        UserId = userId;
    }

}