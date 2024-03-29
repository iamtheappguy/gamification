﻿using Gamification.UseCases.Contracts;

namespace Gamification.Usecases.GetXPRewardsUseCases;

public class GetXpRewardsUseCaseRequestData : ICommandRequest
{
    public string Id { get; private set; }

    public GetXpRewardsUseCaseRequestData(string id)
    {
        Id = id;
    }

}