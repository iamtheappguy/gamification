namespace Gamification.Usecases.GetXPRewardsUseCases;

public interface IGetXpRewardUseCase
{
    Task<GetXpRewardsUseCaseResponse> Call(GetXpRewardsUseCaseRequest data);
}