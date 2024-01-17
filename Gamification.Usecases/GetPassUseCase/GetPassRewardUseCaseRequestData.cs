using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetPassUseCase;

public class GetPassRewardUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }
    public string Name { get; private set; }

    public GetPassRewardUseCaseRequestData(string id, string name)
    {
        Id = id;
        Name = name;
    }

}