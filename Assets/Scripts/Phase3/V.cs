using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class V : MonoBehaviour
{
    public Sprite frame;

    private void OnMouseDown()
    {
        GameObject.Find("SelectorPointer").GetComponent<Image>().sprite = frame;
        Inventory inventory = FindObjectOfType<Inventory>();
        inventory.selectedPotionIndex = 0;
        FindObjectOfType<Customer>().isReady = true;
        FindObjectOfType<InventoryPotions>().Draw(inventory.potionItems, 0);
        FindObjectOfType<X>().gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
