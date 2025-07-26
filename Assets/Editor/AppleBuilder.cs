using UnityEditor;

public class AppleBuilder : AbstractBuilder
{
    public static void Run()
    {
        BuildPlayerOptions buildPlayerOptions = new()
        {
            scenes = GetEnabledScenes(),
            locationPathName = $"Builds/iOS/{PlayerSettings.productName}",
            target = BuildTarget.iOS,
            options = BuildOptions.None,
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}