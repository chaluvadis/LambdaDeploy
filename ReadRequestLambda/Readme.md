# AWS Lambda Empty Function Project

This starter project consists of:
* Function.cs - class file containing a class with a single function handler method
* aws-lambda-tools-defaults.json - default argument settings for use with Visual Studio and command line deployment tools for AWS

You may also have a test project depending on the options selected.

The generated function handler is a simple method accepting a string argument that returns the uppercase equivalent of the input string. Replace the body of this method, and parameters, to suit your needs. 

## Here are some steps to follow to get started from the command line:

Once you have edited your template and code you can deploy your application using the [Amazon.Lambda.Tools Global Tool](https://github.com/aws/aws-extensions-for-dotnet-cli#aws-lambda-amazonlambdatools) from the command line.

Install Amazon.Lambda.Tools Global Tools if not already installed.
```
    dotnet tool install -g Amazon.Lambda.Tools
```

If already installed check if new version is available.
```
    dotnet tool update -g Amazon.Lambda.Tools
```

Install Amazon.Lambda.Test-Tool-6.0 Global Tools if not already installed.
```
    dotnet tool install -g Amazon.Lambda.TestTool-6.0
```

Configure launch.json
```
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".Net 6 AWS Mock Lambda Test",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": <specify the location of aws lambda test tool>,
            "cwd": "${workspaceFolder}",
            "console": "integratedTerminal",
            "stopAtEntry": false,
            "internalConsoleOptions": "openOnSessionStart"
        }
    ]
}
```

Deploy function to AWS Lambda
```
    cd "./ReadRequestLambda"
    dotnet lambda deploy-function
```
