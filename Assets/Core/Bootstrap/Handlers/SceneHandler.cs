

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
    }

    public override async Task<IHandlerContext> Handle(IHandlerContext context)
    {
        _stage.Progress = 0f;
        _stage.Message = "loading_scene";
        _stage.Status = HandlerStatus.Pending;

        AsyncOperationHandle handler = Addressables.LoadSceneAsync(_scene, LoadSceneMode.Additive);

        while (!handler.IsDone)
        {
            DownloadStatus status = handler.GetDownloadStatus();

            _stage.Progress = status.Percent;

            await Task.Yield();
        }

        if (handler.Status == AsyncOperationStatus.Failed)
        {
            _stage.Status = HandlerStatus.Failed;
            _stage.Progress = 1f;
            _stage.Error = handler.OperationException.Message;

            return context;
        }

        _stage.Progress = 1f;
        _stage.Status = HandlerStatus.Completed;

        return await base.Handle(context);
    }
}
