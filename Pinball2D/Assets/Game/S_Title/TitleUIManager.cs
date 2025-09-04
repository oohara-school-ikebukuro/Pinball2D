using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class TitleUIManager : MonoBehaviour
{
    private Button startButton;

    void Start()
    {
        var doc = GetComponent<UIDocument>();
        var root = doc.rootVisualElement;

        startButton = root.Q<Button>("StartButton");
        startButton.clicked += OnStart;
    }

    void OnStart()
    {
        SceneManager.LoadScene("Main");
    }
}
