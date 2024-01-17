namespace Gamification.Functions.Contracts.GamificationGetRewards
{
    public class GamificationGetRewardsFunctionResponse : FunctionResponse<GamificationGetRewardsFunctionResponseData>
    {
        public GamificationGetRewardsFunctionResponse(bool success, GamificationGetRewardsFunctionResponseData data) : base(success, data)
        {
        }
    }
}
