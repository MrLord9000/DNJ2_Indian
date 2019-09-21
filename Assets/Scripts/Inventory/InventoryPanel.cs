using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
#pragma warning disable
    [SerializeField] bool isFocused = false;
    [SerializeField] float focusTime = 4f;
#pragma warning restore

    private List<Button> uiSlots;
    private int currentSlot = 0;

    private void OnEnable()
    {
        Inventory.OnInventoryExtend += ExtendInventoryGUI;
    }

    private void OnDisable()
    {
        Inventory.OnInventoryExtend -= ExtendInventoryGUI;
    }

    private void Start()
    {
        uiSlots = new List<Button>(GetComponentsInChildren<Button>());
        RefreshInventorySlots();
        StartCoroutine(LoseFocusCoroutine());
    }

    public void GetFocus()
    {

    }

    public void LoseFocus()
    {

    }

    public void NextElement()
    {
        if (isFocused)
        {
            if (currentSlot < GameManager.Inventory.slots)
            {
                currentSlot++;
            }
            else
            {
                currentSlot = 0;
            }
        }
    }

    public void PreviousElement()
    {
        if (isFocused)
        {
            if (currentSlot > 0)
            {
                currentSlot--;
            }
            else
            {
                currentSlot = GameManager.Inventory.slots;
            }
        }
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

    private IEnumerator LoseFocusCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(focusTime);
            LoseFocus();
        }
    }
}
