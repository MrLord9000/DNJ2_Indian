using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class InventoryUI : MonoBehaviour
{
    List<IInventoryItem> items;
    RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {
        items = GameManager.Inventory.items;
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    [ContextMenu("Refresh")]
    public void Refresh()
    {
        float space =  rt.rect.width / 100;

        Vector2 pointer = new Vector2(space, Screen.height - space);

        foreach (IInventoryItem item in items)
        {
            GameObject obj = Instantiate(GameManager.SlotUIPrefab);
            Image img = obj.GetComponent<Image>();

            obj.transform.SetParent(transform);
            obj.transform.position = transform.position;
            /*
            GameObject obj = new GameObject();
            Image img = obj.AddComponent<Image>();
            RectTransform rt = obj.GetComponent<RectTransform>();

            img.sprite = item.Image;
            rt.SetParent(transform);

            rt.localPosition = pointer;
            rt.sizeDelta = img.sprite.texture.texelSize;

            pointer.x += item.Image.texture.width + space;*/

        }
    }
}
