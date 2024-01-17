using Gamification.UseCases.Contracts;
namespace Gamification.Usecases.GetXPRewardsUseCases;

public class GetXpRewardsUseCaseResponse : CommandResponse<GetXpRewardsUseCaseResponseData>
{
    public GetXpRewardsUseCaseResponse(bool success, GetXpRewardsUseCaseResponseData data) : base(success, data)
    {
    }
}