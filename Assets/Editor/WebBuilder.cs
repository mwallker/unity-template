using UnityEditor;

public class WebBuilder : AbstractBuilder
{
    public static void Run()
    {
        PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Disabled;
        PlayerSettings.WebGL.enableWebGPU = true;
        PlayerSettings.WebGL.webAssemblyTable = true;
        PlayerSettings.WebGL.webAssemblyBigInt = true;

        BuildPlayerOptions buildPlayerOptions = new()
        {
            scenes = GetEnabledScenes(),
            locationPathName = $"Builds/WebGL/{PlayerSettings.productName}",
            target = BuildTarget.WebGL,
            options = BuildOptions.None,
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}