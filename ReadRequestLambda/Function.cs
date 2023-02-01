using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using System.Text.Json;
// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ReadRequestLambda;

public class Function
{

    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
    {
        context.Logger.LogLine($"ReadRequestLambda - {request.Body}");
        var secretkey1 = Environment.GetEnvironmentVariable("secretkey1");
        var secretkey2 = Environment.GetEnvironmentVariable("secretkey2");
        request.Body = JsonSerializer.Serialize(new { secretkey1, secretkey2 });
        return $"ReadRequestLambda - {request.Body.ToUpper()}";
    }
}
