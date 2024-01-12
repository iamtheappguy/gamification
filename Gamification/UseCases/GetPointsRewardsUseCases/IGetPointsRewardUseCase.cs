using Gamification.Interfaces.UseCases;

namespace Gamification.UseCases.GetPointsRewardsUseCases;

public interface IGetPointsRewardUseCase
{
    Task<GetPointsRewardsUseCaseResponse> Call(GetPointsRewardsUseCaseRequest data);
}