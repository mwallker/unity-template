using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;

public static class ProjectBuilder
{
  private const string APP_NAME = "Template";

  public static void BuildWindows()
  {
    BuildPlayerOptions buildPlayerOptions = new()
    {
      scenes = GetEnabledScenes(),
      locationPathName = $"Builds/Windows/{APP_NAME}.exe",
      target = BuildTarget.StandaloneWindows64,
      options = BuildOptions.None
    };

    BuildPipeline.BuildPlayer(buildPlayerOptions);
  }

  public static void BuildWebGL()
  {
    BuildPlayerOptions buildPlayerOptions = new()
    {
      scenes = GetEnabledScenes(),
      locationPathName = $"Builds/WebGL/{APP_NAME}",
      target = BuildTarget.WebGL,
      options = BuildOptions.None
    };

    BuildPipeline.BuildPlayer(buildPlayerOptions);
  }

  public static void BuildAndroid()
  {
    BuildPlayerOptions buildPlayerOptions = new()
    {
      scenes = GetEnabledScenes(),
      locationPathName = $"Builds/Android/{APP_NAME}.apk",
      target = BuildTarget.Android,
      options = BuildOptions.None,
    };

    BuildPipeline.BuildPlayer(buildPlayerOptions);
  }

  public static void BuildIOS()
  {
    BuildPlayerOptions buildPlayerOptions = new()
    {
      scenes = GetEnabledScenes(),
      locationPathName = $"Builds/iOS/{APP_NAME}",
      target = BuildTarget.iOS,
      options = BuildOptions.None,
    };

    BuildPipeline.BuildPlayer(buildPlayerOptions);
  }

  // Helper method to get the paths of all scenes in the project
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