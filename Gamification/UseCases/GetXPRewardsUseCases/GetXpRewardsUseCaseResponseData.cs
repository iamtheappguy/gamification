using Gamification.Core;

namespace Gamification.UseCases.GetXPRewardsUseCases;

public class GetXpRewardsUseCaseResponseData : CommandResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public double Xp { get; private set; }

    public GetXpRewardsUseCaseResponseData(String id, String name, double xp)
    {
        Id = id;
        Name = name;
        Xp = xp;
    }
}