using UnityEditor;
using UnityEditor.Build;

public class AndroidBuilder : AbstractBuilder
{
    public static void Run()
    {
        PlayerSettings.SetScriptingBackend(NamedBuildTarget.Android, ScriptingImplementation.IL2CPP);
        // PlayerSettings.Android.useCustomKeystore = true;
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64 | AndroidArchitecture.ARMv7;
        // PlayerSettings.Android.bundleVersionCode++;

        EditorUserBuildSettings.buildAppBundle = true;

        // throw new System.Exception("ffffffff");

        BuildPlayerOptions buildPlayerOptions = new()
        {
            scenes = GetEnabledScenes(),
            locationPathName = $"Builds/Android/{PlayerSettings.productName}.aab",
            target = BuildTarget.Android,
            options = BuildOptions.Development,
        };


        PrintBuildReport(BuildPipeline.BuildPlayer(buildPlayerOptions));
    }
}