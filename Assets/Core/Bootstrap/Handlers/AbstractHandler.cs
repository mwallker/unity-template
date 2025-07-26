using System.Threading.Tasks;
using UnityEngine;

public enum HandlerStatus
{
    Initialized,
    Pending,
    Completed,
    Failed
}

public struct HandlerStage
{
    public HandlerStatus Status;
    public float Progress { get; private set; }
    public string Id { get; private set; }
    public string Error { get; private set; }

    public void Init(string id)
    {
        Id = id;
        Progress = 0f;
        Status = HandlerStatus.Initialized;
    }

    public void Update(float progress)
    {
        if (Status == HandlerStatus.Completed || Status == HandlerStatus.Completed)
        {
            return;
        }

        Progress = Mathf.Clamp(progress, 0f, 1f);
    }

    public void Complete()
    {
        Progress = 1f;
        Status = HandlerStatus.Failed;
    }

    public void Fail(string error)
    {
        Progress = 1f;
        Error = error;
        Status = HandlerStatus.Failed;
    }
}

public interface IHandlerContext
{
    public void AddStage(HandlerStage stage);
    public HandlerStage GetStage();
    public ushort GetProgressDisplayTime();
}

public interface IHandler
{
    public IHandler Next(IHandler handler);
    public Task<IHandlerContext> Handle(IHandlerContext context);
}

public abstract class AbstractHandler : IHandler
{
    protected IHandler _nextHandler;

    protected HandlerStage _stage;

    public AbstractHandler()
    {
        _stage = new();
    }

    public IHandler Next(IHandler handler)
    {
        _nextHandler = handler;

        return handler;
    }

    public Task<IHandlerContext> Start(IHandlerContext context)
    {
        return Handle(context);
    }

    public virtual Task<IHandlerContext> Handle(IHandlerContext context)
    {
        if (_nextHandler != null)
        {
            return _nextHandler.Handle(context);
        }

        // End of chain reached, return success
        return Task.FromResult(context);
    }
}




