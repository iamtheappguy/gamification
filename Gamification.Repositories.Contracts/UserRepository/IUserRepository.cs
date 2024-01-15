using Gamification.Repositories.Contracts.UserRepository.GetById;

namespace Gamification.Repositories.Contracts.UserRepository;

public interface IUserRepository
{
    GetByIdUserRepositoryResponse GetById(string userId);
}