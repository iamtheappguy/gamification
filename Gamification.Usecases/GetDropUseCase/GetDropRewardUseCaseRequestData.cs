using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetDropUseCase;

public class GetDropRewardUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }
    public string Name { get; private set; }

    public GetDropRewardUseCaseRequestData(string id, string name)
    {
        Id = id;
        Name = name;
    }

}