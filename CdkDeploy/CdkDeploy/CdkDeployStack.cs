using System;
using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Constructs;

namespace CdkDeploy;
public class CdkDeployStack : Stack
{
    internal CdkDeployStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
    {
        var readRequestLambda = new Function(this, "ReadRequestLambda-Dev", new FunctionProps
        {
            Runtime = Runtime.DOTNET_6,
            Code = Code.FromAsset("../ReadRequestLambda/bin/Release/net6.0/publish"),
            Handler = "ReadRequestLambda::ReadRequestLambda.Function::FunctionHandler",
            FunctionName = "ReadRequestLambda-Dev",
            Description = $"Deployed on {DateTime.Now:yyyy-MM-dd HH:mm:ss}",
        });

        readRequestLambda.AddEnvironment("secretkey1", "It's a secret key1 to everybody");
        readRequestLambda.AddEnvironment("secretkey2", "It's a secret key2 to everybody");
    }
}
