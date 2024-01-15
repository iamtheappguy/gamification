using Gamification.Core;

namespace Gamification.UseCases.GetPointsRewardsUseCase;

public class GetPointsRewardsUseCaseResponse : CommandResponse<GetPointsRewardsUseCaseResponseData>
{
    public GetPointsRewardsUseCaseResponse(bool success, GetPointsRewardsUseCaseResponseData data) : base(success, data)
    {
    }
}