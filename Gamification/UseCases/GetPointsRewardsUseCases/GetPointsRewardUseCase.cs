using Gamification.Interfaces.UseCases;
using Gamification.Repositories.Interfaces;
using Gamification.UseCases.GetXPRewardsUseCases;
using GamificationRewards.Calculators;

namespace Gamification.UseCases.GetPointsRewardsUseCases
{
    public class GetPointsRewardUseCase : ICommand<GetPointsRewardsUseCaseRequest, GetPointsRewardsUseCaseResponse>, IGetPointsRewardUseCase
    {
        private readonly IUserRewardsRepository _userRewardsRepository;
        private readonly ICalculateRewardsXP _calculateRewardPoints;

        public GetPointsRewardUseCase(IUserRewardsRepository userRewardsRepository, ICalculateRewardsXP calculateRewardsXp)
        {
            _userRewardsRepository = userRewardsRepository;
            _calculateRewardPoints = calculateRewardsXp;
        }

        public async Task<GetPointsRewardsUseCaseResponse> Call(GetPointsRewardsUseCaseRequest data)
        {
            var points = _userRewardsRepository.GetPointsById(data.UserId);
            var xp = _userRewardsRepository.GetXpById(data.UserId);

            return await Task.FromResult(new GetPointsRewardsUseCaseResponse(true, new GetPointsRewardsUseCaseResponseData("432814", "Krzy Nobberto", 4763)));
        }
    }
}