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
    [SerializeField] List<Image> uiSlots;
    [SerializeField] Sprite emptySlotSprite;
#pragma warning restore

    private int currentSlot = 0;
    private Vector2 nextPosition;

    public List<Image> UiSlots { get => uiSlots; set => uiSlots = value; }

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
        foreach (var slot in UiSlots)
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

    private void Update()
    {
        Draw(GameManager.Inventory.flowerItems);
    }

    public void Draw( List<Flower> list )
    {
        int n = (list?.Count ?? 0);

        for (int i = 0; i < n; i++)
        {
            UiSlots[i].sprite = Resources.Load<Sprite>( "Sprites/interface/bag_" + list[i].Color );
        }
        for (int i = n; i < UiSlots.Count; i++)
        {
            UiSlots[i].sprite = emptySlotSprite;
        }

    }

}
