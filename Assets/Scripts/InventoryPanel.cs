using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    public Image selectedIcon;
    public TMP_Text descriptionText;
    public Transform rightPanelTransform;
    public GameObject itemButtonPrefab;

    
    public void OnOpen()
    {
        // Clear the right panel
        foreach (Transform child in rightPanelTransform)
        {
            Destroy(child.gameObject);
        }

        // Populate the right panel with item buttons
        for (int i = 0; i < InventoryManager.instance.inventoryList.Count; i++)
        {
            GameObject itemButtonObj = Instantiate(itemButtonPrefab, rightPanelTransform);

            ItemButton itemButtonComp = itemButtonObj.GetComponent<ItemButton>();
            itemButtonComp.data = InventoryManager.instance.inventoryList[i];
            itemButtonComp.icon.sprite = itemButtonComp.data.itemIcon;

            Button button = itemButtonObj.GetComponent<Button>();
            button.onClick.AddListener(() =>
            {
                selectedIcon.sprite = itemButtonComp.data.itemIcon;
                descriptionText.text = itemButtonComp.data.itemDescription;
            });
        }
    }
    
}
