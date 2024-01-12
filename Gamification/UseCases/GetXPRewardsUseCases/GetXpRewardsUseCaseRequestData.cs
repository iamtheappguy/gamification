using Gamification.Interfaces;

namespace Gamification.UseCases.GetXPRewardsUseCases;

public class GetXpRewardsUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }
    public string Name { get; private set; }

    public GetXpRewardsUseCaseRequestData(String id, String name)
    {
        Id = id;
        Name = name;
    }

}