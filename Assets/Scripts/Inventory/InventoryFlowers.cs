using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryFlowers : MonoBehaviour
{
#pragma warning disable
    [SerializeField] bool isFocused = false;
    [SerializeField] float focusTime = 4f;
    [SerializeField] List<Button> uiSlots;
#pragma warning restore

    private int currentSlot = 0;
    private Vector2 nextPosition;

    private void OnEnable()
    {
        Inventory.OnInventoryExtend += ExtendInventoryGUI;
    }

    private void OnDisable()
    {
        Inventory.OnInventoryExtend -= ExtendInventoryGUI;
    }

    public void ExtendInventoryGUI()
    {
        RefreshInventorySlots();
    }

    private void RefreshInventorySlots()
    {
        int i = 0;
        foreach (var slot in uiSlots)
        {
            if (i < GameManager.Inventory.slots)
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
}
