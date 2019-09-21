using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InventoryPotions : MonoBehaviour
{
#pragma warning disable
    [SerializeField] bool isFocused = false;
    [SerializeField] float focusTime = 4f;
    [SerializeField] List<GameObject> uiSlots;
    [SerializeField] Sprite frameSelected;
    [SerializeField] Sprite frameUnselected;
#pragma warning restore

    private int currentSlot = 0;

    private void OnEnable()
    {
        Inventory.OnUsePotion += OnUsePotion;
    }

    private void OnDisable()
    {
        Inventory.OnUsePotion -= OnUsePotion;
    }

    private void Start()
    {
        if(uiSlots == null)
        {
            uiSlots = new List<GameObject>(GetComponentsInChildren<GameObject>());
        }
        RefreshInventorySlots();
        StartCoroutine(LoseFocusCoroutine());
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

    private void OnUsePotion()
    {
        GameManager.Inventory.UsePotion(currentSlot);
        RefreshInventorySlots();
    }

    public void GetFocus()
    {
        isFocused = true;
        GameManager.Inventory.potionItems[currentSlot].GetComponent<Image>().sprite = frameSelected;
    }

    public void LoseFocus()
    {
        isFocused = false;
        GameManager.Inventory.potionItems[currentSlot].GetComponent<Image>().sprite = frameUnselected;
    }

    public void ChangeElement(InputAction.CallbackContext context)
    {
        //float way = context.ReadValue<float>();
        //if (way > 0) NextElement();
        //else if (way < 0) PreviousElement();
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
        else GetFocus();
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
        else GetFocus();
    }

    private IEnumerator LoseFocusCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(focusTime);
            LoseFocus();
        }
    }
}
