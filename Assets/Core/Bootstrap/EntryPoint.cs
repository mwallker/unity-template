using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

[DefaultExecutionOrder(-50)]
public class EntryPoint : MonoBehaviour
{
    [SerializeField]
    private AssetReference _nextScene;

    private readonly EntryPointContext _context = new();

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    async void Start()
    {
        // Services initialization
        AuthenticationHandler authenticationHandler = new();
        RemoteConfigHandler remoteConfigsHandler = new();
        SceneHandler sceneHandler = new(_nextScene);

        // Build chain of handlers
        // authenticationHandler
            //.Next(remoteConfigsHandler)
            //.Next(sceneHandler);

        await authenticationHandler.Start(_context);

        Debug.Log($"Load start {_context.GetStage().Id}");
    }

    void Update()
    {
        var stage = _context.GetStage();

        // Debug.Log($"Load for {stage.Message} {stage.Progress}");
    }
}

