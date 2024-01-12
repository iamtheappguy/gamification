using Gamification.Core;
using Gamification.Interfaces;

namespace Gamification.UseCases.GetXPRewardsUseCases;

public class GetXpRewardsUseCaseRequest : ICommandRequest
{
    private readonly GetXpRewardsUseCaseRequestData _getXpRewardsUseCaseData;

    public GetXpRewardsUseCaseRequest(GetXpRewardsUseCaseRequestData getXpRewardsUseCaseData)
    {
        _getXpRewardsUseCaseData = getXpRewardsUseCaseData;
    }

}