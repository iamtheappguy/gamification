namespace GamificationRewards.Calculators;

public interface ICalculatePoints
{
    bool Add(decimal reward);
    bool Remove();
    bool Multiply();
    bool Divide();
}