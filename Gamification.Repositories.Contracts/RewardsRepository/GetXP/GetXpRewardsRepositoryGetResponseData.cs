namespace Gamification.Repositories.Contracts.RewardsRepository.GetXP;

public class GetXpRewardsRepositoryGetResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Points { get; private set; }

    public GetXpRewardsRepositoryGetResponseData(string id, string name, int points)
    {
        Id = id;
        Name = name;
        Points = points;
    }

}