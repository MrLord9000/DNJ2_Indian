using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
#pragma warning disable
    [SerializeField] GameTimer gameTimer;
    [SerializeField] GameObject player;
    [SerializeField] Inventory inventory;
    [Space]
    [SerializeField] GameObject flowerPrefab;
    [SerializeField] GameObject potionPrefab;
#pragma warning restore
    public bool areFlowersDraggable;
    public int basePlayTime = 120;

    private static GameManager instance;

    public static GameTimer GameTimer
    {   get => instance.gameTimer;   }

    public static GameManager Instance
    {   get => instance;    }

    public static Inventory Inventory
    {   get => instance.inventory;    }

    public static GameObject Player
    {   get => instance.player; }

    public static GameObject FlowerPrefab
    { get => instance.flowerPrefab; }

    public static GameObject PotionPrefab
    {   get => instance.potionPrefab;    }

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
