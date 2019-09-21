using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class InventoryFlowers : MonoBehaviour
{
#pragma warning disable
    [SerializeField] bool isFocused = false;
    [SerializeField] float focusTime = 4f;
    [SerializeField] List<Button> uiSlots;
    [SerializeField] Sprite emptySlotSprite;
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

    void Start()
    {
        uiSlots = GetComponentsInChildren<Button>().ToList();
        Draw(null);
    }

    public void Draw( List<Flower> list )
    {
        int n = (list?.Count ?? 0);

        Debug.Log("aaa");
        for (int i = 0; i < n; i++)
        {
            uiSlots[i].image.sprite = list[i].Image;
        }
        for (int i = n; i < uiSlots.Count; i++)
        {
            uiSlots[i].image.sprite = emptySlotSprite;
            Debug.Log("cleared" + i);
        }

    }

}
