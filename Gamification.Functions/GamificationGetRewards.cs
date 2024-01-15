using System.Net;
using Gamification.Usecases.GetPointsRewardsUseCase;
using Gamification.Usecases.GetSeasonPassUseCase;
using Gamification.Usecases.GetXPRewardsUseCases;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Gamification.Functions
{
    public class GamificationGetRewards
    {
        private readonly IGetPointsRewardUseCase _getPointsRewardUseCase;
        private readonly IGetPassRewardUseCase _getXpRewardUseCase;
        private readonly ILogger _logger;

        public GamificationGetRewards(ILoggerFactory loggerFactory, IGetPointsRewardUseCase getPointsRewardUseCase, IGetPassRewardUseCase getXpRewardUseCase)
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

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString(xpResult.Result.Data.Name);

            return response;
        }
    }
}
