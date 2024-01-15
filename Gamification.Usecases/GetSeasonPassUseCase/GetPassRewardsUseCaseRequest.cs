using Gamification.Interfaces;

namespace Gamification.Usecases.GetSeasonPassUseCase;

public class GetPassRewardsUseCaseRequest : ICommandRequest
{
    private readonly GetPassRewardsUseCaseRequestData _getXpRewardsUseCaseData;

    public GetPassRewardsUseCaseRequest(GetPassRewardsUseCaseRequestData getXpRewardsUseCaseData)
    {
        _getXpRewardsUseCaseData = getXpRewardsUseCaseData;
    }

}