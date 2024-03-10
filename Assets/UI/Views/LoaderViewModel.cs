using UnityEngine;
using UnityEngine.UIElements;

public class LoaderViewModel : MonoBehaviour
{
    [SerializeField]
    private UIDocument document;

    private VisualElement root;

    void Start()
    {
        root = document.rootVisualElement;
        var label = root.Q<Label>();

        if (label != null)
        {
            label.text = "Loading...";
        }
    }
}
