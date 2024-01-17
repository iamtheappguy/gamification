using System.Net;
using System.Net.Http.Json;
using System.Text;
using Azure;
using Gamification.Functions.Contracts;
using Gamification.Functions.Contracts.GamificationGetRewards;
using Gamification.Usecases.GetPassUseCase;
using Gamification.Usecases.GetPointsRewardsUseCase;
using Gamification.Usecases.GetXPRewardsUseCases;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Gamification.Functions
{
    public class GamificationGetRewards
    {
        private readonly IGetPointsRewardUseCase _getPointsRewardUseCase;
        private readonly IGetXpRewardUseCase _getXpRewardUseCase;
        private readonly ILogger _logger;

        public GamificationGetRewards(ILoggerFactory loggerFactory, IGetPointsRewardUseCase getPointsRewardUseCase, IGetXpRewardUseCase getXpRewardUseCase)
        {
            _logger = loggerFactory.CreateLogger<GamificationGetRewards>();
            _getPointsRewardUseCase = getPointsRewardUseCase;
            _getXpRewardUseCase = getXpRewardUseCase;
        }

        [Function("GamificationGetRewards")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var userId = "23439";
            var pointsResult = _getPointsRewardUseCase.Call(new GetPointsRewardsUseCaseRequest(userId));
            var xpResult = _getXpRewardUseCase.Call(new GetXpRewardsUseCaseRequest(new GetXpRewardsUseCaseRequestData(userId)));

            // use calculator


            // response
            var pointsResultData = pointsResult.Result.Data;
            var xpResultData = xpResult.Result.Data;

            var pointsResponseData = new GamificationGetRewardsFunctionResponse(true,
                new GamificationGetRewardsFunctionResponseData(userId, pointsResultData.Name, pointsResultData.Points,
                    xpResultData.Xp));

            return req.CreateJsonResponse(HttpStatusCode.OK, pointsResponseData.ToJson());
        }
    }
}
