using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "Inventory", order = 1)]
public class Inventory : ScriptableObject
{
    [Header("Flower Inventory")]
    public int slots = 3;
    public int maxFlowerSlots = 9;
    public List<Flower> flowerItems = new List<Flower>();
    [Space]
    [Header("Potion Inventory")]
    public int maxPotionSlots = 20;
    public List<Potion> potionItems = new List<Potion>();

    public event System.EventHandler<InventoryEventArgs> ItemAdded;

    public delegate void InventoryExtendAction();
    public static event InventoryExtendAction OnInventoryExtend;

    public delegate void AddFlowerAction();
    public static event AddFlowerAction OnAddFlower;

    public delegate void UsePotionAction();
    public static event UsePotionAction OnUsePotion;

    public void AddFlower(Flower flower)
    {
        if(flowerItems.Count < slots)
        {
            flowerItems.Add(flower);
            //OnAddFlower();
            flower.OnPickup();

            ItemAdded?.Invoke(this, new InventoryEventArgs(flower));
        }
        else
        {
            Debug.Log("<color=yellow>The flower inventory is full</color>");
        }
    }

    public void UsePotion(int i)
    {
        Potion potion = potionItems[i];
        if (potionItems.Count < maxPotionSlots)
        {
            potionItems.Add(potion);
            OnUsePotion();
            potion.OnPickup();

            ItemAdded?.Invoke(this, new InventoryEventArgs(potion));
        }
        else
        {
            Debug.Log("<color=blue>The potion inventory is full</color>");
        }
    }

    [ContextMenu("Extend Inventory")]
    public void ExtendInventory()
    {
        if(slots + 1 <= maxFlowerSlots)
        {
            slots += 1;
            OnInventoryExtend();
        }
    }
}
