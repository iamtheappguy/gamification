using Gamification.Repositories;
using Gamification.Repositories.Contracts.PassRepository;
using Gamification.Repositories.Contracts.RewardsRepository;
using Gamification.Repositories.Contracts.UserRepository;
using Gamification.Repositories.Contracts.UserRewards;
using Gamification.UseCases.GetPointsRewardsUseCase;
using Gamification.UseCases.GetSeasonPassUseCase;
using GamificationRewards.Calculators;
using Microsoft.Extensions.DependencyInjection;

namespace GamificationFunctions
{
    internal class IoC
    {
        public static void Configure(IServiceCollection builder)
        {
            // calculators - You don't really need a factory, this one is for an example
            var factory = new CalculateRewardsFactory();
            builder.AddSingleton((ICalculateRewardsXP)factory.Build(CalculateRewardsFactoryBuildItem.CalculateXP));
            builder.AddSingleton((ICalculateRewardsPoints)factory.Build(CalculateRewardsFactoryBuildItem.CalculatePoints));

            // repositories
            builder.AddTransient<IRewardsRepository, RewardsRepository>();
            builder.AddTransient<IUserRewardsRepository, UserRewardsRepository>();
            builder.AddTransient<IUserRepository, UserRepository>();
            builder.AddTransient<IPassRepository, PassRepository>();

            // user cases 
            builder.AddTransient<IGetPointsRewardUseCase, GetPointsRewardUseCase>();
            builder.AddTransient<IGetPassRewardUseCase, GetPassRewardUseCase>();
        }
    }
}
