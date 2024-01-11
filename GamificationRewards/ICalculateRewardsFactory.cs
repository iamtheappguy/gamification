using GamificationRewards.Calculators;

namespace GamificationRewards;

public interface ICalculateRewardsFactory
{
    ICalculateReward Build(CalculateRewardsFactoryBuildItem calculateRewardsFactoryBuildItem);
}