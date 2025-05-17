using UnityEngine;

public class ShowOnRunGame : MonoBehaviour
{
    public GameObject gameObjectToShow; // Reference to the GameObject to show

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("ShowOnRunGame script started"); // Log message to console
        gameObjectToShow.SetActive(true); // activate this GameObject on start
    }

    
}
