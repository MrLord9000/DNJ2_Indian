using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plus : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener( Action );
        transform.position += new Vector3(65, 0, 0) * (GameManager.Inventory.slots - 3);
    }

    private void Action()
    {
        if( GameManager.Inventory.bank >= 10)
        {
            GameManager.Inventory.bank -= 10;
            GameManager.Inventory.ExtendInventory();
            transform.position += new Vector3(65, 0, 0);

            if (GameManager.Inventory.slots == 10)
                Destroy(gameObject);
        }
    }
}
