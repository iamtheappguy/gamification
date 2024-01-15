﻿using Gamification.Interfaces;

namespace Gamification.Usecases.GetXPRewardsUseCases;

public class GetXpRewardsUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }
    public string Name { get; private set; }

    public GetXpRewardsUseCaseRequestData(string id, string name)
    {
        Id = id;
        Name = name;
    }

}