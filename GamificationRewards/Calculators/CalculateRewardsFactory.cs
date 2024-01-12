namespace GamificationRewards.Calculators
{
    public class CalculateRewardsFactory : ICalculateRewardsFactory
    {
        public ICalculateReward Build(CalculateRewardsFactoryBuildItem calculateRewardsFactoryBuildItem)
        {
            switch (calculateRewardsFactoryBuildItem)
            {
                case CalculateRewardsFactoryBuildItem.CalculateXP:
                {
                    return new CalculateRewardsXP();
                }
                case CalculateRewardsFactoryBuildItem.CalculatePoints:
                    return new CalculateRewardsPoints();
                default:
                    throw new NotImplementedException("unknown CalculateRewardsFactoryBuildItem");
            }
        }



    }
}
