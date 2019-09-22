using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

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
    public Dictionary<FlowerColor, int> flowers = new Dictionary<FlowerColor, int>()
    {
        { FlowerColor.yellow,   0 },
        { FlowerColor.red,      0 },
        { FlowerColor.blue,     0 },
        { FlowerColor.green,    0 },
        { FlowerColor.pink,     0 },
        { FlowerColor.orange,   0 },
        { FlowerColor.purple,   0 },
        { FlowerColor.white,    0 },
        { FlowerColor.black,    0 }
    };

    public int bank = 0;
    public DefaultControls inputActions;

    public delegate void InventoryExtendAction();
    public static event InventoryExtendAction OnInventoryExtend;

    public delegate void FlowerPickAction();
    public static event FlowerPickAction OnFlowerPick;

    private void Start()
    {
        //inputActions = GameManager.Player.GetComponent<PlayerController>().inputActions;
        DontDestroyOnLoad(this);
        //inputActions.Player.InventoryScroll.performed += ChangeSelection;
        //inputActions.Player.InventoryUse.performed += UseSelection;
    }

    public void ChangeSelection(CallbackContext context)
    {
        float value = context.ReadValue<float>();
        if (value == 1)
        {
            NextPotion();
            FindObjectOfType<InventoryPotions>().Draw(potionItems, selectedPotionIndex);
        }
        else if (value == -1)
        {
            PrevPotion();
            FindObjectOfType<InventoryPotions>().Draw(potionItems, selectedPotionIndex);
        }
    }

    public void UseSelection(CallbackContext context)
    {
        SelectedPotion?.Use();
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.P))
    //    {
    //        NextPotion();
    //        potionsGUI.Draw(potionItems, selectedPotionIndex);
    //    }
    //    else if ( Input.GetKeyDown(KeyCode.I))
    //    {
    //        PrevPotion();
    //        potionsGUI.Draw(potionItems, selectedPotionIndex);
    //    }
    //    else if (Input.GetKeyDown(KeyCode.O))
    //    {
    //        SelectedPotion?.Use();
    //    }
    //}

    public void AddFlower(Flower flower)
    {
        if(flowerItems.Count < slots)
        {
            flowerItems.Add(flower);
            flower.OnPickup();
            OnFlowerPick?.Invoke();
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
            FindObjectOfType<InventoryPotions>().Draw(potionItems,selectedPotionIndex);
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


    public int selectedPotionIndex = 0;

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
