using System;

using UnityEditor;
using UnityEditor.Build.Reporting;


public abstract class AbstractBuilder
{
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
}