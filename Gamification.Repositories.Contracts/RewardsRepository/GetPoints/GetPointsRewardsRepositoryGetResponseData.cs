namespace Gamification.Repositories.Contracts.RewardsRepository.GetPoints
{
    public class GetPointsRewardsRepositoryGetResponseData
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Points { get; private set; }

        public GetPointsRewardsRepositoryGetResponseData(string id, string name, int points)
        {
            Id = id;
            Name = name;
            Points = points;
        }

    }
}
