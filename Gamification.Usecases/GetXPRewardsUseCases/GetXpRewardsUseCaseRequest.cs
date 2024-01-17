using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetXPRewardsUseCases;

public class GetXpRewardsUseCaseRequest : ICommandRequest
{
    public GetXpRewardsUseCaseRequestData Data { get; private set; }

    // different way to have a request payload
    public GetXpRewardsUseCaseRequest(GetXpRewardsUseCaseRequestData getXpRewardsUseCaseRequestData)
    {
        Data = getXpRewardsUseCaseRequestData;
    }
}
