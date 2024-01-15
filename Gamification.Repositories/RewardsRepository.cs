using Gamification.Repositories.Contracts.RewardsRepository;
using Gamification.Repositories.Contracts.RewardsRepository.GetPoints;
using Gamification.Repositories.Contracts.RewardsRepository.GetXP;

namespace Gamification.Repositories
{
    public class RewardsRepository : IRewardsRepository
    {
        public GetPointsRewardsRepositoryGetResponse GetPoints()
        {
            return new GetPointsRewardsRepositoryGetResponse(true, string.Empty,
                new GetPointsRewardsRepositoryGetResponseData("122", "Tier 1", 5467));
        }

        public GetXpRewardsRepositoryGetResponse GetXp()
        {
            return new GetXpRewardsRepositoryGetResponse(true, string.Empty,
                new GetXpRewardsRepositoryGetResponseData("67", "XP", 753453));
        }
    }
}
