namespace Gamification.Functions.Contracts.GamificationGetRewards;

public class GamificationGetRewardsFunctionResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Points { get; private set; }

    public double Xp { get; private set; }

    public GamificationGetRewardsFunctionResponseData(string id, string name, int points, double xp)
    {
        Id = id;
        Name = name;
        Points = points;
        Xp = xp;
    }
}