namespace Gamification.Repositories.Contracts.UserRewardsRepository.GetPoints;

public class GetPointsUserRewardsRepositoryGetResponse : RepositoryResponse<GetPointsUserRewardsRepositoryGetResponseData>
{
    public GetPointsUserRewardsRepositoryGetResponse(bool success, string message, GetPointsUserRewardsRepositoryGetResponseData data) : base(success, message, data)
    {
    }
}