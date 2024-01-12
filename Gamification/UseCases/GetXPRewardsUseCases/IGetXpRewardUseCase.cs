
namespace Gamification.UseCases.GetXPRewardsUseCases;

public interface IGetXpRewardUseCase
{
    Task<GetXpRewardsUseCaseResponse> Call(GetXpRewardsUseCaseRequest data);
}