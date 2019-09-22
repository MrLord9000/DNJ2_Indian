using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine.SceneManagement;

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
        DontDestroyOnLoad(this);

        if (FindObjectsOfType<Inventory>().Length > 1)
        {
            Destroy(gameObject);
            Debug.Log("-----------------------------------");
            FindObjectOfType<InventoryPotions>().Draw(FindObjectOfType<Inventory>().potionItems,0);
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextPotion();
            FindObjectOfType<InventoryPotions>().Draw(potionItems, selectedPotionIndex);
        }
        else if ( Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PrevPotion();
            FindObjectOfType<InventoryPotions>().Draw(potionItems, selectedPotionIndex);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            string scene = SceneManager.GetActiveScene().name;

            if ( scene == "Phase_1" )
            {
                SelectedPotion?.Use();

            }
            else if (scene == "Phase_3" && FindObjectOfType<Customer>().isReady && SelectedPotion != null )
            {
                Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaa");
                FindObjectOfType<Customer>().GivePotion(SelectedPotion);
            }
            else
            {
                goto aaa;
            }

            try
            {
                potionItems.RemoveAt(selectedPotionIndex);
            }
            catch(System.ArgumentOutOfRangeException)
            { }

            FindObjectOfType<InventoryPotions>().Draw(potionItems, selectedPotionIndex);
        }
        aaa:;

    }

    public bool AddFlower(Flower flower)
    {
        if(flowerItems.Count < slots)
        {
            flowerItems.Add(flower);
            flower.OnPickup();
            OnFlowerPick?.Invoke();
            return true;
        }
        else
        {
            Debug.Log("<color=yellow>The flower inventory is full</color>");
            return false;
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
