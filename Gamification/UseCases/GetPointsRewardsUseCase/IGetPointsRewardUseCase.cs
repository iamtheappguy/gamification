namespace Gamification.UseCases.GetPointsRewardsUseCase;

public interface IGetPointsRewardUseCase
{
    Task<GetPointsRewardsUseCaseResponse> Call(GetPointsRewardsUseCaseRequest data);
}