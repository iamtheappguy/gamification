using Gamification.Repositories.Contracts.PassRepository;
using Gamification.UseCases.Contracts;
using Gamification.Usecases.GetDropUseCase;
using Gamification.Usecases.GetXPRewardsUseCases;

namespace Gamification.Usecases.GetPassUseCase
{
    public class GetPassRewardUseCase : ICommand<GetPassRewardUseCaseRequest, GetPassRewardUseCaseResponse>, IGetPassRewardUseCase
    {
        private readonly IPassRepository _passRepository;

        public GetPassRewardUseCase(IPassRepository passRepository)
        {
            _passRepository = passRepository;
        }

        public Task<GetPassRewardUseCaseResponse> Call(GetPassRewardUseCaseRequest data)
        {
            throw new NotImplementedException();
        }
    }
}