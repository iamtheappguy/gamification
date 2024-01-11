using System.IO;
using GamificationRewards;
using GamificationRewards.Calculators;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GamificationFunctions
{
    internal class IoC
    {
        public static void Configure(IServiceCollection builder)
        {
            var factory = new CalculateRewardsFactory();
            builder.AddSingleton((ICalculateXP)factory.Build(CalculateRewardsFactoryBuildItem.CalculateXP));
            builder.AddSingleton((ICalculatePoints)factory.Build(CalculateRewardsFactoryBuildItem.CalculatePoints));
        }
    }
}
