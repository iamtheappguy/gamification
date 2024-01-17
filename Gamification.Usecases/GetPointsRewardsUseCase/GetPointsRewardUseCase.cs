using Gamification.Repositories.Contracts.UserRewardsRepository;
using Gamification.Rewards.Calculators;
using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetPointsRewardsUseCase
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
            
            return await Task.FromResult(new GetPointsRewardsUseCaseResponse(true, new GetPointsRewardsUseCaseResponseData(points.Data.Id, points.Data.Name, points.Data.Points)));
        }
    }
}