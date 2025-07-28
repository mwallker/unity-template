using System.Collections.Generic;
using System.Linq;

public class EntryPointContext : IHandlerContext
{
    private const ushort _progressDisplayTime = 500;
    private readonly List<HandlerStage> _stages = new();

    public EntryPointContext()
    {
        HandlerStage initialStage = new();

        _stages.Add(initialStage);

        // initialStage.Init("game_initialized");
        // initialStage.Complete();
    }

    public void AddStage(HandlerStage stage)
    {
        _stages.Add(stage);
    }

    public HandlerStage GetStage()
    {
        return _stages.Last();
    }

    public ushort GetProgressDisplayTime()
    {
        return _progressDisplayTime;
    }
}