using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build;

public class Builder
{
  public static void Run_Android()
  {
    PlayerSettings.SetScriptingBackend(NamedBuildTarget.Android, ScriptingImplementation.IL2CPP);
    PlayerSettings.Android.bundleVersionCode++;

    Run(BuildTarget.Android, $"Builds/Android/{PlayerSettings.productName}.apk");
  }

  public static void Run_iOS()
  {
    Run(BuildTarget.iOS, $"Builds/iOS/{PlayerSettings.productName}");
  }

  public static void Run_WebGL()
  {
    PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Disabled;
    PlayerSettings.WebGL.enableWebGPU = true;
    PlayerSettings.WebGL.webAssemblyTable = true;
    PlayerSettings.WebGL.webAssemblyBigInt = true;

    Run(BuildTarget.WebGL, $"Builds/WebGL/{PlayerSettings.productName}");
  }

  public static void Run_Windows()
  {
    Run(BuildTarget.StandaloneWindows64, $"Builds/Windows/{PlayerSettings.productName}.exe");
  }

  private static void Run(BuildTarget target, string locationPathName)
  {
    BuildPlayerOptions buildPlayerOptions = new()
    {
      scenes = GetEnabledScenes(),
      locationPathName = locationPathName,
      target = target,
      options = BuildOptions.None,
    };

    BuildPipeline.BuildPlayer(buildPlayerOptions);
  }

  private static string[] GetEnabledScenes()
  {
    List<string> ScenePaths = new();

    for (int i = 0; i < EditorBuildSettings.scenes.Length; i++)
    {
      if (EditorBuildSettings.scenes[i].enabled)
      {
        ScenePaths.Add(EditorBuildSettings.scenes[i].path);
      }
    }

    return ScenePaths.ToArray();
  }
}