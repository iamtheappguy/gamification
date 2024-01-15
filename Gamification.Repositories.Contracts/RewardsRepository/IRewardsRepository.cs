using Gamification.Repositories.Contracts.RewardsRepository.GetPoints;
using Gamification.Repositories.Contracts.RewardsRepository.GetXP;

namespace Gamification.Repositories.Contracts.RewardsRepository
{
    public interface IRewardsRepository
    {
        GetPointsRewardsRepositoryGetResponse GetPoints();
        GetXpRewardsRepositoryGetResponse GetXp();

    }
}
