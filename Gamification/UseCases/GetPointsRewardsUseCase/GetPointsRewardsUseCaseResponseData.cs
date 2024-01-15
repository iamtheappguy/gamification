using Gamification.Core;

namespace Gamification.UseCases.GetPointsRewardsUseCase;

public class GetPointsRewardsUseCaseResponseData : CommandResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Points { get; private set; }

    public GetPointsRewardsUseCaseResponseData(String id, String name, int points)
    {
        Id = id;
        Name = name;
        Points = points;
    }
}