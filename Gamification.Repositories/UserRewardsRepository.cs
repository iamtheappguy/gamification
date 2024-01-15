using Gamification.Repositories.Contracts.UserRewardsRepository;
using Gamification.Repositories.Contracts.UserRewardsRepository.GetPoints;
using Gamification.Repositories.Contracts.UserRewardsRepository.GetXP;

namespace Gamification.Repositories
{
    public class UserRewardsRepository : IUserRewardsRepository
    {
        public GetPointsUserRewardsRepositoryGetResponse GetPointsById(string userId)
        {
            throw new NotImplementedException();
        }

        public GetPointsUserXpRepositoryGetResponse GetXpById(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
