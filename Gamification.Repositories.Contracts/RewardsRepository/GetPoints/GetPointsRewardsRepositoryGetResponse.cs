namespace Gamification.Repositories.Contracts.RewardsRepository.GetPoints;

public class GetPointsRewardsRepositoryGetResponse : RepositoryResponse<GetPointsRewardsRepositoryGetResponseData>
{
    public GetPointsRewardsRepositoryGetResponse(bool success, string message, GetPointsRewardsRepositoryGetResponseData data) : base(success, message, data)
    {
    }
}