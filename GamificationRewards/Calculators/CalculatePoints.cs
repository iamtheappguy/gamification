namespace GamificationRewards.Calculators
{
    public class CalculatePoints : ICalculateReward, ICalculatePoints
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
