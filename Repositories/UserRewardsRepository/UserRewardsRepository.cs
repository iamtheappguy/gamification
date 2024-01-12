using Gamification.Repositories.Interfaces;

namespace Gamification.Repositories.UserRewardsRepository
{
    public class UserRewardsRepository : IUserRewardsRepository
    {
        public int GetPointsById(string userId)
        {
            return 67943;
        }

        public double GetXpById(string userId)
        {
            return 432.65;
        }
    }
}
