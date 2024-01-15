namespace Gamification.Repositories.Contracts.UserRewards.GetXP;

public class GetPointsUserXpRepositoryGetResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Points { get; private set; }

    public GetPointsUserXpRepositoryGetResponseData(string id, string name, int points)
    {
        Id = id;
        Name = name;
        Points = points;
    }

}