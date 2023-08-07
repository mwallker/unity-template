using UnityEditor;

public static class ProjectBuilder
{
  private static readonly string[] scenes = new[] { "Assets/Scenes/DefaultScene.unity" };

  public static void BuildWindows()
  {
    BuildPlayerOptions buildPlayerOptions = new()
    {
      scenes = scenes,
      locationPathName = "Builds/Windows/Template.exe",
      target = BuildTarget.StandaloneWindows64,
      options = BuildOptions.None
    };

    BuildPipeline.BuildPlayer(buildPlayerOptions);
  }

  public static void BuildWebGL()
  {
    BuildPlayerOptions buildPlayerOptions = new()
    {
      scenes = scenes,
      locationPathName = "Builds/WebGL/Template",
      target = BuildTarget.WebGL,
      options = BuildOptions.None
    };

    BuildPipeline.BuildPlayer(buildPlayerOptions);
  }
}