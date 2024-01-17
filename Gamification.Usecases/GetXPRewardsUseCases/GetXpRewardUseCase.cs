using Gamification.Repositories.Contracts.DropRepository;
using Gamification.Repositories.Contracts.PassRepository;
using Gamification.Repositories.Contracts.UserRewardsRepository;
using Gamification.Rewards.Calculators;
using Gamification.Usecases.GetPointsRewardsUseCase;
using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetXPRewardsUseCases
{
    public class GetXpRewardUseCase : ICommand<GetXpRewardsUseCaseRequest, GetXpRewardsUseCaseResponse>, IGetXpRewardUseCase
    {
        private readonly IUserRewardsRepository _userRewardsRepository;
        private readonly ICalculateRewardsXP _calculateRewardPoints;

        public GetXpRewardUseCase(IUserRewardsRepository userRewardsRepository, ICalculateRewardsXP calculateRewardsXp)
        {
            _userRewardsRepository = userRewardsRepository;
            _calculateRewardPoints = calculateRewardsXp;
        }

        public async Task<GetXpRewardsUseCaseResponse> Call(GetXpRewardsUseCaseRequest data)
        {
            var xp = _userRewardsRepository.GetXpById(data.Data.Id);
            return await Task.FromResult(new GetXpRewardsUseCaseResponse(true, new GetXpRewardsUseCaseResponseData(xp.Data.Id, xp.Data.Name, xp.Data.Xp)));
        }

    }
}