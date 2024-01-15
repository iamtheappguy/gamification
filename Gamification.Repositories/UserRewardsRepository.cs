using Gamification.Repositories.Contracts.UserRewards;

namespace Gamification.Repositories
{
    public class UserRewardsRepository : IUserRewardsRepository
    {
        public int GetPointsById(string id)
        {
            return 67943;
        }

        public double GetXpById(string id)
        {
            return 432.65;
        }
    }
}
