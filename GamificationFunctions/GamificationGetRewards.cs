using System.Net;
using Gamification.Core;
using Gamification.UseCases.GetPointsRewardsUseCases;
using Gamification.UseCases.GetXPRewardsUseCases;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace GamificationFunctions
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

            var xpResult = _getPointsRewardUseCase.Call(new GetPointsRewardsUseCaseRequest("23432"));
            

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString(xpResult.Result.Data.Name);

            return response;
        }
    }
}