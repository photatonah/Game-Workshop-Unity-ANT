using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
