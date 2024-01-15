using Gamification.Repositories.Contracts.UserRewardsRepository.GetPoints;
using Gamification.Repositories.Contracts.UserRewardsRepository.GetXP;

namespace Gamification.Repositories.Contracts.UserRewardsRepository
{
    public interface IUserRewardsRepository
    {
        GetPointsUserRewardsRepositoryGetResponse GetPointsById(string userId);
        GetPointsUserXpRepositoryGetResponse GetXpById(string userId);
    }
}
