using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ThePot : MonoBehaviour
{
    [SerializeField] Color neutralColor;

    private FlowerColor? slot1 = null;
    private FlowerColor? slot2 = null;

    private BoxCollider2D collider;

    public bool Ready
    {
        get => slot1 != null && slot2 != null;
    }

    public bool AddFlower( FlowerColor flower )
    {
        if ( --GameManager.Inventory.flowers[flower] < 0 )
        {
            GameManager.Inventory.flowers[flower] = 0;
            return false;
        }

        foreach( Corner corner in GameManager.Instance.corners)
        {
            corner.Refresh();
        }

        if ( slot1 == null )
        {
            slot1 = flower;
            GetComponent<SpriteRenderer>().color = flower.GetColor();
            return true;
        }
        else if (slot2 == null)
        {
            slot2 = flower;
            GetComponent<SpriteRenderer>().color = neutralColor;
            GameManager.Inventory.AddPotion(CreatePotion());
            FindObjectOfType<InventoryPotions>().Draw(GameManager.Inventory.potionItems, 0);
            return true;
        }
        else
        {
            return false;
        }
    }

    [ContextMenu("CreatePotion")]
    public Potion CreatePotion()
    {
        if( !Ready )
        {
            return null;
        }

        GameObject obj = Instantiate(GameManager.PotionPrefab);
        DontDestroyOnLoad(obj);
        obj.SetActive(false);
        Potion potion = obj.GetComponent<Potion>();
        potion.Set((FlowerColor)slot1, (FlowerColor)slot2);
        slot1 = slot2 = null;
        return potion;

    }



    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        SpriteRenderer[] rend = GetComponentsInChildren<SpriteRenderer>();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            FlowerColor? color = GameManager.Instance.selectedFlowerColor;
            if( color != null )
            {
                AddFlower((FlowerColor)color);
            }

        }

    }

}
