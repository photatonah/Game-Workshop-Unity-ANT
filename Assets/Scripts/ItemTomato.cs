using UnityEngine;

public class ItemTomato : MonoBehaviour, IInteractable
{
    // Implement the Interact method from the IInteractable interface
    public void Interact()
    {
        // Code to handle the interaction with the tomato item
        Debug.Log("Tomato item interacted with!");
    }
}
