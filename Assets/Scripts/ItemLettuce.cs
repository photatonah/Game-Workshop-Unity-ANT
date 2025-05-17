using UnityEngine;

public class ItemLettuce : MonoBehaviour, IInteractable
{
    // Implement the Interact method from the IInteractable interface
    public void Interact()
    {
        // Code to handle the interaction with the lettuce item
        Debug.Log("Lettuce item interacted with!");
    }
}
