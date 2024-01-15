namespace Gamification.Repositories.Contracts.PassRepository.GetById;

public class GetByIdPassRepositoryGetResponseData
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public double Cost { get; private set; }

    public GetByIdPassRepositoryGetResponseData(string id, string name, int cost)
    {
        Id = id;
        Name = name;
        Cost = cost;
    }

}