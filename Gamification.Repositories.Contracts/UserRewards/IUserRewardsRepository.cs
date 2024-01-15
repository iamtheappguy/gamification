using Gamification.Repositories.Contracts.UserRewards.GetPoints;
using Gamification.Repositories.Contracts.UserRewards.GetXP;

namespace Gamification.Repositories.Contracts.UserRewards
{
    public interface IUserRewardsRepository
    {
        GetPointsUserRewardsRepositoryGetResponse GetPointsById(string userId);
        GetPointsUserXpRepositoryGetResponse GetXpById(string userId);
    }
}
