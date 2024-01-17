using Gamification.Repositories.Contracts.UserRewardsRepository;
using Gamification.Repositories.Contracts.UserRewardsRepository.GetPoints;
using Gamification.Repositories.Contracts.UserRewardsRepository.GetXP;

namespace Gamification.Repositories
{
    public class UserRewardsRepository : IUserRewardsRepository
    {
        public GetPointsUserRewardsRepositoryGetResponse GetPointsById(string userId)
        {
            return new GetPointsUserRewardsRepositoryGetResponse(true, string.Empty, new GetPointsUserRewardsRepositoryGetResponseData("121", "User 1", 6545));
        }

        public GetPointsUserXpRepositoryGetResponse GetXpById(string userId)
        {
            return new GetPointsUserXpRepositoryGetResponse(true, string.Empty, new GetPointsUserXpRepositoryGetResponseData("121", "User 1", 754500.01));
        }
    }
}
