using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void OnStartButtonClick()
    {
        // Load the game scene
        SceneManager.LoadScene("Gameplay");
    }

    public void OnExitButtonClick()
    {
        // Exit the application
        Application.Quit();
    }
}
