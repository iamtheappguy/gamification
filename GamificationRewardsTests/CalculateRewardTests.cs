using GamificationRewards;
using GamificationRewards.Calculators;
using Xunit;

     namespace GamificationRewardsTests
     { 
         public class CalculateRewardTests
         {
             [Fact]
             public void CalculateRewardTests_Add_ReturnTrue()
             {
                 var primeService = new CalculateRewardsPoints();
                 bool result = primeService.Add(1);

                 Assert.True(result, "1 should not be prime");
             }
         }
     }