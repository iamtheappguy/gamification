using System.Net;
using Microsoft.Azure.Functions.Worker.Http;

namespace Gamification.Functions;

public static class Extension
{
    public static HttpResponseData CreateJsonResponse(this HttpRequestData req, HttpStatusCode httpStatusCode, string payload)
    {
        var response = req.CreateResponse(httpStatusCode);
        response.Headers.Add("Content-Type", "text/json; charset=utf-8");
        response.WriteString(payload);
        return response;
    }
}