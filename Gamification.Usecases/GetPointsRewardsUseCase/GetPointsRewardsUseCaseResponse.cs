using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetPointsRewardsUseCase;

public class GetPointsRewardsUseCaseResponse : CommandResponse<GetPointsRewardsUseCaseResponseData>
{
    public GetPointsRewardsUseCaseResponse(bool success, GetPointsRewardsUseCaseResponseData data) : base(success, data)
    {
    }
}