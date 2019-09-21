using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    List<IInventoryItem> items;

    // Start is called before the first frame update
    void Start()
    {
        items = GameManager.GetInstance().GetInventory().items;
    }

    // Update is called once per frame
    void Update()
    {
    }

    [ContextMenu("Refresh")]
    public void Refresh()
    {
        int space = Screen.width / 100;

        Vector2 pointer = new Vector2(space, Screen.height - space);

        foreach (IInventoryItem item in items)
        {
            GameObject obj = new GameObject();
            Image img = obj.AddComponent<Image>();
            RectTransform rt = obj.GetComponent<RectTransform>();

            img.sprite = item.Image;

        }
    }
}
