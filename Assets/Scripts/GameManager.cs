using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
#pragma warning disable
    [SerializeField] private GameObject player;
    [SerializeField] private Inventory inventory;
#pragma warning restore

    private static GameManager instance;

    public static GameManager GetInstance()
    {
        return instance;
    }

    public Inventory GetInventory()
    {
        return inventory;
    }

    public GameObject GetPlayer()
    {
        return player;
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
}
