using Gamification.Interfaces.UseCases;
using Gamification.Repositories.Contracts.UserRewards;
using GamificationRewards.Calculators;

namespace Gamification.UseCases.GetPointsRewardsUseCase
{
    public class GetPointsRewardUseCase : ICommand<GetPointsRewardsUseCaseRequest, GetPointsRewardsUseCaseResponse>, IGetPointsRewardUseCase
    {
        private readonly IUserRewardsRepository _userRewardsRepository;
        private readonly ICalculateRewardsPoints _calculateRewardPoints;

        public GetPointsRewardUseCase(IUserRewardsRepository userRewardsRepository, ICalculateRewardsPoints calculateRewardPoints)
        {
            _userRewardsRepository = userRewardsRepository;
            _calculateRewardPoints = calculateRewardPoints;
        }

        public async Task<GetPointsRewardsUseCaseResponse> Call(GetPointsRewardsUseCaseRequest data)
        {
            var points = _userRewardsRepository.GetPointsById(data.UserId);

            return await Task.FromResult(new GetPointsRewardsUseCaseResponse(true, new GetPointsRewardsUseCaseResponseData("432814", "Krzy Nobberto", 4763)));
        }
    }
}