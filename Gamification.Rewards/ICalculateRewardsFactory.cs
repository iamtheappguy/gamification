using Gamification.Rewards.Calculators;

namespace Gamification.Rewards;

public interface ICalculateRewardsFactory
{
    ICalculateReward Build(CalculateRewardsFactoryBuildItem calculateRewardsFactoryBuildItem);
}