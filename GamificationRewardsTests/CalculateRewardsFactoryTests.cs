using GamificationRewards;
using GamificationRewards.Calculators;
using Xunit;

     namespace GamificationRewardsTests
     { 
         public class CalculateRewardsFactoryTests
    {
             [Fact]
             public void CalculateRewardsFactoryTests_Build_CalculateXP()
             {
                 ICalculateRewardsFactory calculateRewardsFactory = new CalculateRewardsFactory();
                 ICalculateReward result = calculateRewardsFactory.Build(CalculateRewardsFactoryBuildItem.CalculateXP);

                 Assert.IsType<CalculateXP>(result);
             }

            [Fact]
            public void CalculateRewardsFactoryTests_Build_CalculateReward()
            {
                ICalculateRewardsFactory calculateRewardsFactory = new CalculateRewardsFactory();
                ICalculateReward result = calculateRewardsFactory.Build(CalculateRewardsFactoryBuildItem.CalculatePoints);

                Assert.IsType<CalculatePoints>(result);
            }
        }
    }