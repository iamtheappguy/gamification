namespace Gamification.Repositories.Contracts.RewardsRepository.GetXP
{
    public class GetXpRewardsRepositoryGetResponse : RepositoryResponse<GetXpRewardsRepositoryGetResponseData>
    {
        public GetXpRewardsRepositoryGetResponse(bool success, string message, GetXpRewardsRepositoryGetResponseData data) : base(success, message, data)
        {
        }
    }
}
