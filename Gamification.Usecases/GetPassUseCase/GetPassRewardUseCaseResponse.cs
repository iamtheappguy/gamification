using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetPassUseCase;

public class GetPassRewardUseCaseResponse : CommandResponse<GetPassRewardUseCaseResponseData>
{
    public GetPassRewardUseCaseResponse(bool success, GetPassRewardUseCaseResponseData data) : base(success, data)
    {
    }
}