using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CdkDeploy
{
    sealed class Program
    {
        public static void Main()
        {
            var app = new App();
            _ = new CdkDeployStack(app, "LambdaDeployStack", null);
            app.Synth();
        }
    }
}
