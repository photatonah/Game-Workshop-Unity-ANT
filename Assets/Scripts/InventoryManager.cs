using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    

    public List<ItemData> inventoryList = new List<ItemData>();
    
    public void AddItem(ItemData item)
    {
        inventoryList.Add(item);
        Debug.Log("Item added: " + item.itemName);
    }

    public int GetItemAmount(ItemData item)
    {
        int count = 0;
        foreach (ItemData i in inventoryList)
        {
            if (i == item)
            {
                count++;
            }
        }
        return count;
    }
}