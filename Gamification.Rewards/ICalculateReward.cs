namespace Gamification.Rewards;

public interface ICalculateReward
{
    public bool Add(decimal reward);
    public bool Remove();
    public bool Multiply();
    public bool Divide();
}