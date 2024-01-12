using Gamification.Repositories.Interfaces;
using Gamification.Repositories.RewardsRepository;
using Gamification.Repositories.UserRepository;
using Gamification.Repositories.UserRewardsRepository;
using Gamification.UseCases.GetPointsRewardsUseCases;
using Gamification.UseCases.GetXPRewardsUseCases;
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

            // user cases 
            builder.AddTransient<IGetPointsRewardUseCase, GetPointsRewardUseCase>();
            builder.AddTransient<IGetXpRewardUseCase, GetXpRewardUseCase>();
        }
    }
}
