using GamificationCleanCode;
using GamificationRewards;

namespace GamificationCleanCode
{
    public interface ICommandData<T>
    {
    }

    public interface ICommandResponseData<T>
    {
    }

    public class CommandData<T> : ICommandData<T>
    {
        public CommandData(T data)
        {
            Data = data;
        }

        public T Data { get; }
    }

    public class CommandResponseData<T> : ICommandResponseData<T>
    {
        public CommandResponseData(bool success, T data)
        {
            Success = success;
            Data = data;
        }

        public bool Success { get; }

        public T Data { get; }
    }

    public class PointsRewardsCommandData : CommandData<PointsRewardsCommandData>
    {
        public PointsRewardsCommandData(PointsRewardsCommandData data) : base(data)
        {
        }
    }

    public class PointsRewardsCommandResponseData : CommandResponseData<PointsRewardsCommandResponseData>
    {
        public PointsRewardsCommandResponseData(bool success, PointsRewardsCommandResponseData data) : base(success, data)
        {
        }
    }


    public interface ICommand<TRequest, TResponse>
    {
        Task<CommandResponseData<TResponse>> Call(ICommandData<TRequest> data);
    }


    public class GetPointsRewardsCommand : ICommand<PointsRewardsCommandData, PointsRewardsCommandResponseData>
    {
        private readonly ICalculateReward _calculateReward;

        public GetPointsRewardsCommand(ICalculateReward calculateReward)
        {
            _calculateReward = calculateReward;
        }

        public async Task<CommandResponseData<PointsRewardsCommandResponseData>> Call(ICommandData<PointsRewardsCommandData> data)
        {
            return await Task.FromResult(new CommandResponseData<PointsRewardsCommandResponseData>(true, null));
        }

    }
}