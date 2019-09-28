using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Plus : MonoBehaviour
{
    public int price;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener( Action );
        transform.position += new Vector3(65, 0, 0) * (GameManager.Inventory.slots - 3);
        GetComponentInChildren<TextMeshProUGUI>().text = price.ToString();
    }
    
    private void Action()
    {
        if( GameManager.Inventory.bank >= price)
        {
            GameManager.Inventory.bank -= price;
            GameManager.Inventory.ExtendInventory();
            transform.position += new Vector3(65, 0, 0);

            if (GameManager.Inventory.slots == price)
                Destroy(gameObject);
        }
    }
}
