using Gamification.Repositories.Contracts.DropRepository;
using Gamification.Rewards.Calculators;
using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetDropUseCase
{
    public class GetDropRewardUseCase : ICommand<GetDropRewardUseCaseRequest, GetDropRewardUseCaseResponse>, IGetDropRewardUseCase
    {
        private readonly IDropRepository _dropRepository;
        
        public GetDropRewardUseCase(IDropRepository dropRepository)
        {
            _dropRepository = dropRepository;
        }

        public Task<GetDropRewardUseCaseResponse> Call(GetDropRewardUseCaseRequest data)
        {
            throw new NotImplementedException();
        }
    }
}