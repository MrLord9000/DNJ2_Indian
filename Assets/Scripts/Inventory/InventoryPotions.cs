using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Linq;

public class InventoryPotions : MonoBehaviour
{
#pragma warning disable
    [SerializeField] bool isFocused = false;
    [SerializeField] float focusTime = 4f;
    [SerializeField] List<Button> uiSlots;
    [SerializeField] Sprite frameSelected;
    [SerializeField] Sprite frameUnselected;
    [SerializeField] Sprite emptySlotSprite;
#pragma warning restore

    private int currentSlot = 0;

    private void Start()
    {
        uiSlots = GetComponentsInChildren<Button>().ToList();
        Draw(null);
        //RefreshInventorySlots();
        //StartCoroutine(LoseFocusCoroutine());
    }

    private void Update()
    {
    }
    /*
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
    */
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
        float way = context.ReadValue<float>();
        if (way == 1) NextElement();
        else if (way == -1) PreviousElement();
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
    public void Draw(List<Potion> list)
    {
        int n = (list?.Count ?? 0);

        for (int i = 0; i < n; i++)
        {
            uiSlots[i].image.sprite = list[i].Image;
            uiSlots[i].image.color = list[i].Color.GetColor();
            uiSlots[i].onClick.AddListener(()=>PotionEffects.Invoke(list[i].Action));
        }
        for (int i = n; i < uiSlots.Count; i++)
        {
            uiSlots[i].image.sprite = emptySlotSprite;
        }

    }
}
