using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetDropUseCase;

public class GetDropRewardUseCaseResponseData : CommandResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public double Xp { get; private set; }

    public GetDropRewardUseCaseResponseData(string id, string name, double xp)
    {
        Id = id;
        Name = name;
        Xp = xp;
    }
}