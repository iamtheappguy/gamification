using Gamification.Interfaces;

namespace Gamification.Usecases.GetSeasonPassUseCase;

public class GetPassRewardsUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }
    public string Name { get; private set; }

    public GetPassRewardsUseCaseRequestData(string id, string name)
    {
        Id = id;
        Name = name;
    }

}