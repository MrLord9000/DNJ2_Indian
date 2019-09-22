﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2init : MonoBehaviour
{
    private void Start()
    {
        Inventory inventory = FindObjectOfType<Inventory>();
        foreach (var elem in inventory.flowers)
        {
            Debug.Log(elem.Key + ": " + elem.Value);
        }
        foreach( Potion potion in inventory.potionItems)
        {
            potion.transform.position = new Vector3(1000, 1000, 1000);
            potion.gameObject.SetActive(true);
        }
        FindObjectOfType<InventoryPotions>().Draw(inventory.potionItems,0);
        foreach( Corner corner in GameManager.Instance.corners )
        {
            corner.Refresh();
        }
    }
}
