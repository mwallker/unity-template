using System.Threading.Tasks;

using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using Unity.Services.RemoteConfig;

public class AuthenticationHandler : AbstractHandler
{
    public AuthenticationHandler()
    {
        _stage.Init("authorization_pending");
    }

    public override async Task<IHandlerContext> Handle(IHandlerContext context)
    {
        context.AddStage(_stage);

        // Check for internet connection
        if (!Utilities.CheckForInternetConnection())
        {
            _stage.Fail("no_connection");

            return context;
        }

        // Set the environment
        InitializationOptions options = new InitializationOptions().SetEnvironmentName("development");
        try
        {
            // Initialize handlers for unity game services
            await UnityServices.InitializeAsync(options);

            // Remote config requires authentication for managing environment information
            if (!AuthenticationService.Instance.IsSignedIn)
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
            }

            _stage.Fail("no_connection");
        }
        catch (System.Exception e)
        {
            _stage.Fail(e.Message);

            return context;
        }

        await Task.Delay(context.GetProgressDisplayTime());

        return await base.Handle(context);
    }
}

