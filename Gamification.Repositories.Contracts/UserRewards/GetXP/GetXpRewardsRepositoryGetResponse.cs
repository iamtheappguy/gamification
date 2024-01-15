namespace Gamification.Repositories.Contracts.UserRewards.GetXP
{
    public class GetPointsUserXpRepositoryGetResponse: RepositoryResponse<GetPointsUserXpRepositoryGetResponseData>
    {
        public GetPointsUserXpRepositoryGetResponse(bool success, string message, GetPointsUserXpRepositoryGetResponseData data) : base(success, message, data)
        {
        }
    }
}
