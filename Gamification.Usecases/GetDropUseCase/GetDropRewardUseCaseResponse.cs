using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetDropUseCase;

public class GetDropRewardUseCaseResponse : CommandResponse<GetDropRewardUseCaseResponseData>
{
    public GetDropRewardUseCaseResponse(bool success, GetDropRewardUseCaseResponseData data) : base(success, data)
    {
    }
}