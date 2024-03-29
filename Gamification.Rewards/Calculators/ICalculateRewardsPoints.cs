﻿namespace Gamification.Rewards.Calculators;

public interface ICalculateRewardsPoints
{
    bool Add(decimal reward);
    bool Remove();
    bool Multiply();
    bool Divide();
}