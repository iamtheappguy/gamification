namespace Gamification.Usecases.GetPointsRewardsUseCase;

public interface IGetPointsRewardUseCase
{
    Task<GetPointsRewardsUseCaseResponse> Call(GetPointsRewardsUseCaseRequest data);
}