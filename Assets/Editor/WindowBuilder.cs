using UnityEditor;
using UnityEditor.Build;

public class WindowBuilder : AbstractBuilder
{
    public static void Run()
    {
        PlayerSettings.SetScriptingBackend(NamedBuildTarget.Standalone, ScriptingImplementation.IL2CPP);

        BuildPlayerOptions buildPlayerOptions = new()
        {
            scenes = GetEnabledScenes(),
            locationPathName = $"Builds/Windows/{PlayerSettings.productName}.exe",
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None,
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}