namespace Gamification.Repositories.Contracts.UserRepository.GetById;

public class GetByIdUserRepositoryResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public string GameTag{ get; private set; }

    public GetByIdUserRepositoryResponseData(string id, string name, string gameTag)
    {
        Id = id;
        Name = name;
        GameTag = gameTag;
    }

}