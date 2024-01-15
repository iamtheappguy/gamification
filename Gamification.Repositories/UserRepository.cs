using Gamification.Repositories.Contracts.UserRepository;
using Gamification.Repositories.Contracts.UserRepository.GetById;

namespace Gamification.Repositories
{
    public class UserRepository : IUserRepository
    {
        public GetByIdUserRepositoryResponse GetById(string id)
        {
            return new GetByIdUserRepositoryResponse(true, String.Empty, new GetByIdUserRepositoryResponseData("1", "XBox User", "XBoxUser47826"));
        }
    }
}
