using System.Dynamic;

namespace Gamification.Repositories.Interfaces;

public interface IUserRepository
{
    GetIndexBinder GetById(string userId);
}