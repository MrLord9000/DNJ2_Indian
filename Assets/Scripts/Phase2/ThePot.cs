using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ThePot : MonoBehaviour
{
    private Flower slot1;
    private Flower slot2;

    private SpriteRenderer slotIndicator1;
    private SpriteRenderer slotIndicator2;

    private BoxCollider2D collider;

    public bool Ready
    {
        get => slot1 != null && slot2 != null;
    }

    public bool AddFlower( Flower flower )
    {
        if( slot1 == null )
        {
            slot1 = flower;
            slot1.gameObject.SetActive(false);
            return true;
        }
        else if (slot2 == null)
        {
            slot2 = flower;
            slot2.gameObject.SetActive(false);
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

        Potion potion = Instantiate(Phase2LevelManager.instance.PotionPrefab).GetComponent<Potion>();
        potion.Set(slot1, slot2);
        Destroy(slot1?.gameObject);
        Destroy(slot2?.gameObject);
        slot1 = slot2 = null;
        return potion;

    }


    [ContextMenu("Cancel"),System.Obsolete]
    public void Cancel()
    {
        slot1?.gameObject.SetActive(true);
        slot2?.gameObject.SetActive(true);

    }

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        SpriteRenderer[] rend = GetComponentsInChildren<SpriteRenderer>();
        // 0 is a Pot renderer
        slotIndicator1 = rend[1];
        slotIndicator2 = rend[2];
    }

    // Update is called once per frame
    void Update()
    {
        slotIndicator1.color = slot1?.Color.GetColor() ?? Color.clear;
        slotIndicator2.color = slot2?.Color.GetColor() ?? Color.clear;
    }

}
