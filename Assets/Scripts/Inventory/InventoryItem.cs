using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventoryItem
{
    string Name { get; }
    FlowerColor Color { get; }
    Sprite Image { get; }

    GameObject gameObject { get; }

    void OnPickup();
}

public class InventoryEventArgs : System.EventArgs
{
    public InventoryEventArgs(IInventoryItem item)
    {
        Item = item;
    }

    public IInventoryItem Item; 
}