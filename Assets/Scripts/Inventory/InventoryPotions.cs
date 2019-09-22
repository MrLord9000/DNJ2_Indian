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
    [SerializeField] List<Image> uiSlots;
    [SerializeField] Sprite emptySlotSprite;
    [SerializeField] Sprite selectPointerSprite;
    private GameObject selectPointer;
#pragma warning restore

    private void Awake()
    {
        selectPointer = new GameObject("SelectorPointer");
        selectPointer.transform.SetParent(transform);
        selectPointer.AddComponent<Image>().sprite = selectPointerSprite;
        selectPointer.GetComponent<RectTransform>().localScale *= .6f;
        uiSlots = new List<Image>();
        IEnumerable<Image> images = GetComponentsInChildren<Image>().Skip(1).Reverse();
        foreach( Image image in images)
        {
            if( image.name.Contains("InventorySlot") )
            {
                uiSlots.Add(image);
            }
        }

        Draw(null,0);
    }
    public void Draw(List<Potion> list, int selected)
    {
        int n = (list?.Count ?? 0);
        Debug.Log(n + " " + this + " " + selectPointer);
        selectPointer.transform.position = uiSlots[selected].transform.position;

        for (int i = 0; i < n; i++)
        {

            uiSlots[i].sprite = list[i].Image;
            uiSlots[i].color = list[i].Color.GetColor();
        }
        for (int i = n; i < uiSlots.Count; i++)
        {
            uiSlots[i].sprite = emptySlotSprite;
        }
    }


}
