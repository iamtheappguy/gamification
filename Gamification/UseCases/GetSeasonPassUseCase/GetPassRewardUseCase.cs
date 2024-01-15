using Gamification.Interfaces.UseCases;
using Gamification.Repositories.Contracts.PassRepository;
using Gamification.UseCases.GetXPRewardsUseCases;
using GamificationRewards.Calculators;

namespace Gamification.UseCases.GetSeasonPassUseCase
{
    public class GetPassRewardUseCase : ICommand<GetXpRewardsUseCaseRequest, GetPassRewardsUseCaseResponse>, IGetPassRewardUseCase
    {
        private readonly IPassRepository _userRewardsRepository;
        private readonly ICalculateRewardsXP _calculateRewardPoints;

        public GetPassRewardUseCase(IPassRepository userRewardsRepository, ICalculateRewardsXP calculateRewardsXp)
        {
            _userRewardsRepository = userRewardsRepository;
            _calculateRewardPoints = calculateRewardsXp;
        }

        Task<GetPassRewardsUseCaseResponse> ICommand<GetXpRewardsUseCaseRequest, GetPassRewardsUseCaseResponse>.Call(GetXpRewardsUseCaseRequest data)
        {
            throw new NotImplementedException();
        }

        Task<GetPassRewardsUseCaseResponse> IGetPassRewardUseCase.Call(GetXpRewardsUseCaseRequest data)
        {
            throw new NotImplementedException();
        }
    }
}