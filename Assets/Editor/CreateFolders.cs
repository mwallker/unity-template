using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

public class CreateFolders : EditorWindow
{
  [MenuItem("Assets/Create Default Folders")]
  private static void SetupFolders()
  {
    CreateFolders window = CreateInstance<CreateFolders>();
    window.position = new Rect(Screen.width / 2, Screen.height / 2, 400, 150);
    window.ShowPopup();
  }

  private static void Create()
  {
    List<string> folders = new()
    {
      "Animations",
      "Audio",
      "Fonts",
      "Materials",
      "Meshes",
      "Prefabs",
      "Scripts",
      "Scenes",
      "Shaders",
      "Textures",
      "UI"
    };

    foreach (string folder in folders) {
      if (!Directory.Exists("Assets/" + folder))
      {
        Directory.CreateDirectory("Assets/" + folder);
      }
    }

    AssetDatabase.Refresh();
  }

  void OnGUI()
  {
    EditorGUILayout.LabelField("Are you sure?");
    Repaint();
    if (GUILayout.Button("Generate")) {
      Create();
      Close();
    }
  }
}