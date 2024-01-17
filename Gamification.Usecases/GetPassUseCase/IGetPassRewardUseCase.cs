using Gamification.Usecases.GetXPRewardsUseCases;

namespace Gamification.Usecases.GetPassUseCase;

public interface IGetPassRewardUseCase
{
    Task<GetPassRewardUseCaseResponse> Call(GetPassRewardUseCaseRequest data);
}