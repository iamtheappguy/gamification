using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetPassUseCase;

public class GetPassRewardUseCaseResponseData : CommandResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public double Xp { get; private set; }

    public GetPassRewardUseCaseResponseData(string id, string name, double xp)
    {
        Id = id;
        Name = name;
        Xp = xp;
    }
}