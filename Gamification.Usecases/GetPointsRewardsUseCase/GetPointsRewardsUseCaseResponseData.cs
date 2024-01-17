using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetPointsRewardsUseCase;

public class GetPointsRewardsUseCaseResponseData : CommandResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Points { get; private set; }

    public GetPointsRewardsUseCaseResponseData(string id, string name, int points)
    {
        Id = id;
        Name = name;
        Points = points;
    }
}