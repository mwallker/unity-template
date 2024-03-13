using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Loader : MonoBehaviour
{
    [SerializeField]
    private Texture2D defaultSplashImage;
    private UIDocument document;
    private VisualElement root;
    private Label label;

    void Start()
    {
        document = GetComponent<UIDocument>();
        if (document)
        {
            root = document.rootVisualElement;
        }

        label = root.Q<Label>();
        if (label != null)
        {
            label.text = "Hint";
        }

        root.Q<Label>();
        if (defaultSplashImage != null)
        {
            Debug.Log("Logo loaded");
            root.style.backgroundImage = defaultSplashImage;
        }

        StartCoroutine(HandleProgressChange());
    }

    private IEnumerator HandleProgressChange()
    {
        var progress = root.Q<ProgressBar>();
        if (progress == null)
        {
            yield return null;
        }

        int currentProgress = 0;
        while (currentProgress <= 100)
        {
            progress.value = currentProgress++;

            yield return null;
        }
    }
}
