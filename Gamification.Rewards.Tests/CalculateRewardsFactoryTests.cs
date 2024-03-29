using Gamification.Rewards.Calculators;
using Xunit;

namespace Gamification.Rewards.Tests
     { 
         public class CalculateRewardsFactoryTests
    {
             [Fact]
             public void CalculateRewardsFactoryTests_Build_CalculateXP()
             {
                 ICalculateRewardsFactory calculateRewardsFactory = new CalculateRewardsFactory();
                 ICalculateReward result = calculateRewardsFactory.Build(CalculateRewardsFactoryBuildItem.CalculateXP);

                 Assert.IsType<CalculateRewardsXP>(result);
             }

            [Fact]
            public void CalculateRewardsFactoryTests_Build_CalculateReward()
            {
                ICalculateRewardsFactory calculateRewardsFactory = new CalculateRewardsFactory();
                ICalculateReward result = calculateRewardsFactory.Build(CalculateRewardsFactoryBuildItem.CalculatePoints);

                Assert.IsType<CalculateRewardsPoints>(result);
            }
        }
    }