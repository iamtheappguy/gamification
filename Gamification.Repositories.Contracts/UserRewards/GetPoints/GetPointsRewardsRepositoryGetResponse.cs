using Gamification.Repositories.Contracts.RewardsRepository.GetPoints;

namespace Gamification.Repositories.Contracts.UserRewards.GetPoints;

public class GetPointsUserRewardsRepositoryGetResponse : RepositoryResponse<GetPointsUserRewardsRepositoryGetResponseData>
{
    public GetPointsUserRewardsRepositoryGetResponse(bool success, string message, GetPointsUserRewardsRepositoryGetResponseData data) : base(success, message, data)
    {
    }
}