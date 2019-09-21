using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    private List<Button> uiSlots;
    private int currentSlot;

    private void Start()
    {
        uiSlots = new List<Button>(GetComponentsInChildren<Button>());
        Debug.Log(uiSlots.Count);
        int i = 0;
        foreach (var slot in uiSlots)
        {
            if(i < GameManager.Inventory.slots)
            {
                slot.gameObject.SetActive(true);
            }
            else
            {
                slot.gameObject.SetActive(false);
            }
            i++;
        }
    }

    public void GetFocus()
    {

    }
}
