using System.Collections;
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
    public int potionSlots = 10;
    public List<Potion> potionItems = new List<Potion>();
    InventoryPotions potionsGUI;

    public delegate void InventoryExtendAction();
    public static event InventoryExtendAction OnInventoryExtend;

    private void Awake()
    {
        potionsGUI = FindObjectOfType<InventoryPotions>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            NextPotion();
            potionsGUI.Draw(potionItems, selectedPotionIndex);
        }
        else if ( Input.GetKeyDown(KeyCode.I))
        {
            PrevPotion();
            potionsGUI.Draw(potionItems, selectedPotionIndex);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            SelectedPotion?.Use();
        }
    }

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
        if(potionItems.Count < potionSlots)
        {
            potionItems.Add(potion);
            potionsGUI.Draw(potionItems,selectedPotionIndex);
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


    int selectedPotionIndex = 0;

    bool NextPotion()
    {
        if (selectedPotionIndex < 19)
        {
            selectedPotionIndex++;
            return true;
        }
        return false;
    }
    bool PrevPotion()
    {
        if (selectedPotionIndex > 0)
        {
            selectedPotionIndex--;
            return true;
        }
        return false;
    }

    public Potion SelectedPotion
    {
        get
        {
            try
            {
                return potionItems[selectedPotionIndex];
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return null;
            }
        }
    }
}
