using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
#pragma warning disable
    [SerializeField] GameObject player;
    [SerializeField] Inventory inventory;
    [SerializeField] GameObject slotUIPrefab;
#pragma warning restore

    private static GameManager instance;

    public static GameManager Instance
    {
        get => instance;
    }

    public static Inventory Inventory
    {
        get => instance.inventory;
    }

    public static GameObject Player
    {
        get => instance.player;
    }

    public static GameObject SlotUIPrefab
    {
        get => instance.slotUIPrefab;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            if (inventory == null)
            {
                inventory = (Inventory)Resources.Load("InventoryMain");
            }
        }
        else
        {
            Destroy(this);
        }
    }

    private void ExtendInventory()
    {
        inventory.ExtendInventory();
    }
}
