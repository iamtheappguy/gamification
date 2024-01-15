using Gamification.Core;

namespace Gamification.UseCases.GetSeasonPassUseCase;

public class GetPassRewardsUseCaseResponse : CommandResponse<GetPassRewardsUseCaseResponseData>
{
    public GetPassRewardsUseCaseResponse(bool success, GetPassRewardsUseCaseResponseData data) : base(success, data)
    {
    }
}