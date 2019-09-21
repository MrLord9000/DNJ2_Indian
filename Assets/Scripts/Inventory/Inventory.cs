using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "Inventory", order = 1)]
public class Inventory : ScriptableObject
{
    public int slots = 3;
    public List<IInventoryItem> items = new List<IInventoryItem>();

    public event System.EventHandler<InventoryEventArgs> ItemAdded;

    public void AddItem(IInventoryItem item)
    {
        if(items.Count < slots && !items.Contains(item))
        {
            items.Add(item);
            item.OnPickup();
            //Destroy((item as MonoBehaviour).gameObject);

            ItemAdded?.Invoke(this, new InventoryEventArgs(item));
        }
        else
        {
            Debug.Log("<color=blue>The inventory is full</color>");
        }
    }
}
