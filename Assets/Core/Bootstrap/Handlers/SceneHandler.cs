

using System.Collections.Generic;
using System.Threading.Tasks;

using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SceneHandler : AbstractHandler
{
    private readonly AssetReference _scene;

    public SceneHandler(AssetReference scene)
    {
        _scene = scene;
        // _stage.Init("");
    }

    public override async Task<IHandlerContext> Handle(IHandlerContext context)
    {
        // context.AddStage(_stage);

        AsyncOperationHandle handler = Addressables.LoadSceneAsync(_scene, LoadSceneMode.Additive);

        while (!handler.IsDone)
        {
            // _stage.Update(handler.GetDownloadStatus().Percent);

            await Task.Yield();
        }

        if (handler.Status == AsyncOperationStatus.Failed)
        {
            // _stage.Fail(handler.OperationException.Message);

            return context;
        }

        // _stage.Complete();

        return await base.Handle(context);
    }
}
