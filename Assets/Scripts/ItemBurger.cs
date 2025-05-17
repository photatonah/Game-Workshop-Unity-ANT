using UnityEngine;

public class ItemBurger : MonoBehaviour, IInteractable
{
    // Implement the Interact method from the IInteractable interface
    public void Interact()
    {
        // Code to handle the interaction with the burger item
        Debug.Log("Burger item interacted with!");
    }
}
