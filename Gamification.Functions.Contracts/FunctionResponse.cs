using Newtonsoft.Json;

namespace Gamification.Functions.Contracts;

public class FunctionResponse<T>
{
    public FunctionResponse(bool success, T data)
    {
        Success = success;
        Data = data;
    }

    public bool Success { get; }

    public T Data { get; }

    public string ToJson()
    {
        return JsonConvert.SerializeObject(this);
    }
}