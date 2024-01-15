using Gamification.Interfaces.UseCases;
using Gamification.Repositories.Contracts.PassRepository;
using Gamification.Rewards.Calculators;
using Gamification.Usecases.GetXPRewardsUseCases;

namespace Gamification.Usecases.GetSeasonPassUseCase
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