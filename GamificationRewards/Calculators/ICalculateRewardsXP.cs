namespace GamificationRewards.Calculators;

public interface ICalculateRewardsXP
{
    bool Add(decimal reward);
    bool Remove();
    bool Multiply();
    bool Divide();
}