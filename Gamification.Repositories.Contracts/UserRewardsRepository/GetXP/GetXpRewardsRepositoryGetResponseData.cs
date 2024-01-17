namespace Gamification.Repositories.Contracts.UserRewardsRepository.GetXP;

public class GetPointsUserXpRepositoryGetResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public double Xp{ get; private set; }

    public GetPointsUserXpRepositoryGetResponseData(string id, string name, double xp)
    {
        Id = id;
        Name = name;
        Xp = xp;
    }

}