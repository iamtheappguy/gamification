namespace GamificationRewards.Calculators;

public interface ICalculateXP
{
    bool Add(decimal reward);
    bool Remove();
    bool Multiply();
    bool Divide();
}