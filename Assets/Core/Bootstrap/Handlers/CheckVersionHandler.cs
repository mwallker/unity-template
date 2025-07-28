using System.Threading.Tasks;

public class CheckVersionHandler : AbstractHandler
{
    public CheckVersionHandler()
    {
        // _stage.Init("check_version");
    }

    public override async Task<IHandlerContext> Handle(IHandlerContext context)
    {


        return await base.Handle(context);
    }
}

