using System.Threading.Tasks;

using Unity.Services.RemoteConfig;

public struct UserAttributes
{
    public int Version;
}

public struct AppAttributes
{
    public int Version;
}

public class RemoteConfigHandler : AbstractHandler
{
    public override async Task<IHandlerContext> Handle(IHandlerContext context)
    {
        // HandlerState stage = new() { IsHandled = false, Message = "", Progress = 0f };

        // _state.Progress = 0f;

        // context.AddStage(stage);
        // context.UpdateProgress(new() { Value = 0, IsHandled = false });

        try
        {
            await RemoteConfigService.Instance.FetchConfigsAsync(new UserAttributes(), new AppAttributes());
        }
        catch (System.Exception e)
        {
            // context.UpdateProgress(new() { IsHandled = false, Message = e.Message });

            return context;
        }

        // context.UpdateProgress(new() { IsHandled = true, Message = "", Value = 1f });

        await Task.Delay(500);

        return await base.Handle(context);
    }
}
