﻿using Gamification.Interfaces.UseCases;
using Gamification.Repositories.Interfaces;
using GamificationRewards.Calculators;

namespace Gamification.UseCases.GetXPRewardsUseCases
{
    public class GetXpRewardUseCase : ICommand<GetXpRewardsUseCaseRequest, GetXpRewardsUseCaseResponse>, IGetXpRewardUseCase
    {
        private readonly IUserRewardsRepository _userRewardsRepository;
        private readonly ICalculateRewardsXP _calculateRewardPoints;

        public GetXpRewardUseCase(IUserRewardsRepository userRewardsRepository, ICalculateRewardsXP calculateRewardsXp)
        {
            _userRewardsRepository = userRewardsRepository;
            _calculateRewardPoints = calculateRewardsXp;
        }

        public async Task<GetXpRewardsUseCaseResponse> Call(GetXpRewardsUseCaseRequest data)
        {

            return await Task.FromResult(new GetXpRewardsUseCaseResponse(true, new GetXpRewardsUseCaseResponseData("432814","Krzy Nobberto", 132.23)));
        }

    }
}