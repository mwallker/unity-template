using System;

using UnityEditor;
using UnityEditor.AddressableAssets.Build;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.Build.Reporting;

public abstract class AbstractBuilder
{
    [Serializable]
    private class BuildConfigData
    {
        public string version;
    }

    protected static string[] GetEnabledScenes()
    {
        return EditorBuildSettingsScene.GetActiveSceneList(EditorBuildSettings.scenes);
    }

    protected static void PrintBuildReport(BuildReport report)
    {
        Console.WriteLine("===================================================");
        Console.WriteLine($"Status:     {report.summary.result}");
        Console.WriteLine($"Started At: {report.summary.buildStartedAt}");
        Console.WriteLine($"Ended At:   {report.summary.buildEndedAt}");
        Console.WriteLine($"Build Type: {report.summary.buildType}");
        Console.WriteLine($"itrltn:     {report.summary.totalTime}");
        Console.WriteLine("===================================================");
    }

    public static void BuildContent()
    {
        AddressableAssetSettings.BuildPlayerContent(out AddressablesPlayerBuildResult result);

        Console.WriteLine(result.Duration);
    }
}