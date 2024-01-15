using Gamification.Interfaces;

namespace Gamification.Usecases.GetXPRewardsUseCases;

public class GetXpRewardsUseCaseRequest : ICommandRequest
{
    private readonly GetXpRewardsUseCaseRequestData _getXpRewardsUseCaseData;

    public GetXpRewardsUseCaseRequest(GetXpRewardsUseCaseRequestData getXpRewardsUseCaseData)
    {
        _getXpRewardsUseCaseData = getXpRewardsUseCaseData;
    }

}