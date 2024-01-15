using Gamification.Interfaces;

namespace Gamification.UseCases.GetSeasonPassUseCase;

public class GetPassRewardsUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }
    public string Name { get; private set; }

    public GetPassRewardsUseCaseRequestData(String id, String name)
    {
        Id = id;
        Name = name;
    }

}