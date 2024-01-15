using Gamification.Repositories;
using Gamification.Repositories.Contracts.PassRepository;
using Gamification.Repositories.Contracts.RewardsRepository;
using Gamification.Repositories.Contracts.UserRepository;
using Gamification.Repositories.Contracts.UserRewardsRepository;
using Gamification.Rewards.Calculators;
using Gamification.Usecases.GetPointsRewardsUseCase;
using Gamification.Usecases.GetSeasonPassUseCase;
using Microsoft.Extensions.DependencyInjection;

namespace Gamification.Functions
{
    internal class IoC
    {
        public static void Configure(IServiceCollection builder)
        {
            // calculators - You don't really need a factory, this one is for an example
            // Singleton create once
            var factory = new CalculateRewardsFactory();
            builder.AddSingleton((ICalculateRewardsXP)factory.Build(CalculateRewardsFactoryBuildItem.CalculateXP));
            builder.AddSingleton((ICalculateRewardsPoints)factory.Build(CalculateRewardsFactoryBuildItem.CalculatePoints));

            
            // Transient so create each time a function called, could be singleton really but only hard coded right now

            // repositories
            builder.AddTransient<IPassRepository, PassRepository>();
            builder.AddTransient<IRewardsRepository, RewardsRepository>();
            builder.AddTransient<IUserRepository, UserRepository>();
            builder.AddTransient<IUserRewardsRepository, UserRewardsRepository>();

            // user cases 
            builder.AddTransient<IGetPointsRewardUseCase, GetPointsRewardUseCase>();
            builder.AddTransient<IGetPassRewardUseCase, GetPassRewardUseCase>();
        }
    }
}
