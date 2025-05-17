using UnityEngine;

[CreateAssetMenu(fileName = "IngredientItem", menuName = "Inventory/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
}
