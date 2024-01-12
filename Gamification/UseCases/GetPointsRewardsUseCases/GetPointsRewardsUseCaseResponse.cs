using Gamification.Core;
using Gamification.UseCases.GetXPRewardsUseCases;

namespace Gamification.UseCases.GetPointsRewardsUseCases;

public class GetPointsRewardsUseCaseResponse : CommandResponse<GetPointsRewardsUseCaseResponseData>
{
    public GetPointsRewardsUseCaseResponse(bool success, GetPointsRewardsUseCaseResponseData data) : base(success, data)
    {
    }
}