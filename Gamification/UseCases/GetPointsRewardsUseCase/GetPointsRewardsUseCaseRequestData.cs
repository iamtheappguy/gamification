
using Gamification.Interfaces;

namespace Gamification.UseCases.GetPointsRewardsUseCase;

public class GetPointsRewardsUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public double Points { get; private set; }

    public GetPointsRewardsUseCaseRequestData(String id, String name, int points)
    {
        Id = id;
        Name = name;
        Points = points;
    }

}