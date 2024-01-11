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
                    return new CalculateXP();
                }
                case CalculateRewardsFactoryBuildItem.CalculatePoints:
                    return new CalculatePoints();
                default:
                    throw new NotImplementedException("unknown CalculateRewardsFactoryBuildItem");
            }
        }



    }
}
