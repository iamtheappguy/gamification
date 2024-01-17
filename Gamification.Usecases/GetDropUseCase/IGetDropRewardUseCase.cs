namespace Gamification.Usecases.GetDropUseCase;

public interface IGetDropRewardUseCase
{
    Task<GetDropRewardUseCaseResponse> Call(GetDropRewardUseCaseRequest data);
}