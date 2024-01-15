using Gamification.Usecases.GetXPRewardsUseCases;

namespace Gamification.Usecases.GetSeasonPassUseCase;

public interface IGetPassRewardUseCase
{
    Task<GetPassRewardsUseCaseResponse> Call(GetXpRewardsUseCaseRequest data);
}