using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Phase3init : MonoBehaviour
{
    private void Start()
    {
        Inventory inventory = FindObjectOfType<Inventory>();
        foreach (Potion potion in inventory.potionItems)
        {
            potion.gameObject.SetActive(false);
        }
        FindObjectOfType<InventoryPotions>().Draw(inventory.potionItems, 0);
        GameObject.Find("Money").GetComponent<TextMeshProUGUI>().SetText(inventory.bank.ToString());
    }
}
