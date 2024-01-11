using System.Net;
using GamificationRewards;
using GamificationRewards.Calculators;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace GamificationFunctions
{
    public class GamificationGetRewards
    {
        private readonly ILogger _logger;

        public GamificationGetRewards(ILoggerFactory loggerFactory, ICalculateXP calculateXp, ICalculatePoints calculatePoints)
        {
            _logger = loggerFactory.CreateLogger<GamificationGetRewards>();
        }

        [Function("GamificationGetRewards")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
