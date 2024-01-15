using Gamification.Interfaces;

namespace Gamification.Usecases.GetPointsRewardsUseCase;

public class GetPointsRewardsUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public double Points { get; private set; }

    public GetPointsRewardsUseCaseRequestData(string id, string name, int points)
    {
        Id = id;
        Name = name;
        Points = points;
    }

}