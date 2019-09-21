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
    [SerializeField] Sprite emptySlotSprite;
    [SerializeField] GameObject selectPointer;
#pragma warning restore

    private int currentSlot = 0;

    private void Start()
    {
        uiSlots = GetComponentsInChildren<Button>().Reverse().ToList();
        Draw(null,1);
        //RefreshInventorySlots();
        //StartCoroutine(LoseFocusCoroutine());
    }
    public void Draw(List<Potion> list, int selected)
    {
        int n = (list?.Count ?? 0);

        selectPointer.transform.position = uiSlots[selected].transform.position;
        
        for (int i = 0; i < n; i++)
        {
            uiSlots[i].image.sprite = list[i].Image;
            uiSlots[i].image.color = list[i].Color.GetColor();
        }
        for (int i = n; i < uiSlots.Count; i++)
        {
            uiSlots[i].image.sprite = emptySlotSprite;
        }
    }


}
