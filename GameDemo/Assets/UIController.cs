using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Button startButton;
    public Button messageButton;
    public Button quitButton;
    public Label messageText;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("start-button");
        messageButton = root.Q<Button>("message-button");
        quitButton = root.Q<Button>("quit-button");
        messageText = root.Q<Label>("message-text");

        startButton.clicked += StartButtonPressed;
        messageButton.clicked += MessageButtonPressed;
        quitButton.clicked += QuitButtonPressed;
    }

    void StartButtonPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void MessageButtonPressed()
    {
        Application.OpenURL("https://www.talentastra.com");
    }

    void QuitButtonPressed()
    {
        // Editör ortamýnda ise editörden çýkýþ
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // Uygulamadan çýkýþ
        Application.Quit();
        #endif
    }
}
