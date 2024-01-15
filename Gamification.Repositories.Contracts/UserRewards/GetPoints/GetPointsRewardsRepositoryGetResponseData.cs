namespace Gamification.Repositories.Contracts.UserRewards.GetPoints
{
    public class GetPointsUserRewardsRepositoryGetResponseData
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Points { get; private set; }

        public GetPointsUserRewardsRepositoryGetResponseData(string id, string name, int points)
        {
            Id = id;
            Name = name;
            Points = points;
        }

    }
}
