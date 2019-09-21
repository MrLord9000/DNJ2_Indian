﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    [Header("Flower Inventory")]
    public int slots = 3;
    public int maxFlowerSlots = 9;
    public List<Flower> flowerItems = new List<Flower>();
    [Space]
    [Header("Potion Inventory")]
    public int maxPotionSlots = 20;
    public List<Potion> potionItems = new List<Potion>();

    public delegate void InventoryExtendAction();
    public static event InventoryExtendAction OnInventoryExtend;

    public void AddFlower(Flower flower)
    {
        if(flowerItems.Count < slots)
        {
            flowerItems.Add(flower);
            flower.OnPickup();
        }
        else
        {
            Debug.Log("<color=yellow>The flower inventory is full</color>");
        }
    }

    public void RemoveFlower(int i)
    {
        flowerItems.RemoveAt(i);
    }

    public void AddPotion(Potion potion)
    {
        if(potion != null)
        {
            potionItems.Add(potion);
        }
    }

    public Potion RemovePotion(int i)
    {
        if (potionItems.Count > 0)
        {
            Potion potion = potionItems[i];
            potionItems.RemoveAt(i);
            return potion;
        }
        else
        {
            Debug.Log("<color=blue>The potion inventory is empty</color>");
            return null;
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
