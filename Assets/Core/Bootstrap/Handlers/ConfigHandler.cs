

using System.Threading.Tasks;

using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ConfigHandler : AbstractHandler
{
    public ConfigHandler()
    {

    }

    public override async Task<IHandlerContext> Handle(IHandlerContext context)
    {
        // AsyncOperationHandle handler = Addressables.LoadSceneAsync(_nextScene, LoadSceneMode.Additive);

        // while (!handler.IsDone)
        // {
        //     DownloadStatus status = handler.GetDownloadStatus();

        //     context.ReportProgress(status.Percent, $"Loading next scene... ({status.Percent})");

        //     await Task.Yield();
        // }

        // if (handler.Status == AsyncOperationStatus.Failed)
        // {
        //     return new HandlerResult { Success = false, Message = "Failed to load next scene" };
        // }

        // context.ReportProgress(90, "Loaded successfully");

        // List<string> entries = await Addressables.CheckForCatalogUpdates(true).Task;

        // foreach (var entry in entries)
        // {
        //     Addressables.Log(entry);
        // }

        return await base.Handle(context);
    }
}
