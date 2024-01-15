using Gamification.Repositories.Contracts.RewardsRepository.GetXP;

namespace Gamification.Repositories.Contracts.UserRepository.GetById
{
    public class GetByIdUserRepositoryResponse : RepositoryResponse<GetByIdUserRepositoryResponseData>
    {
        public GetByIdUserRepositoryResponse(bool success, string message, GetByIdUserRepositoryResponseData data) : base(success, message, data)
        {
        }
    }
}