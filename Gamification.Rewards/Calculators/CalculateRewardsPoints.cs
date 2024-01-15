namespace Gamification.Rewards.Calculators
{
    public class CalculateRewardsPoints : ICalculateReward, ICalculateRewardsPoints
    {
        public bool Add(decimal reward)
        {
            return true;
        }

        public bool Remove()
        {
            return false;
        }

        public bool Multiply()
        {
            return false;
        }

        public bool Divide()
        {
            return false;
        }
    }
}
