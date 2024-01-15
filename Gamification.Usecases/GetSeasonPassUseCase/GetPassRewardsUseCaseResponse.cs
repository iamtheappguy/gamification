using Gamification.Core;

namespace Gamification.Usecases.GetSeasonPassUseCase;

public class GetPassRewardsUseCaseResponse : CommandResponse<GetPassRewardsUseCaseResponseData>
{
    public GetPassRewardsUseCaseResponse(bool success, GetPassRewardsUseCaseResponseData data) : base(success, data)
    {
    }
}