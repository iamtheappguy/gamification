
using Gamification.UseCases.GetXPRewardsUseCases;

namespace Gamification.UseCases.GetSeasonPassUseCase;

public interface IGetPassRewardUseCase
{
    Task<GetPassRewardsUseCaseResponse> Call(GetXpRewardsUseCaseRequest data);
}