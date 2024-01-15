using Gamification.Core;

namespace Gamification.UseCases.GetSeasonPassUseCase;

public class GetPassRewardsUseCaseResponseData : CommandResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public double Xp { get; private set; }

    public GetPassRewardsUseCaseResponseData(String id, String name, double xp)
    {
        Id = id;
        Name = name;
        Xp = xp;
    }
}