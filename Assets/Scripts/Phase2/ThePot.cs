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
            return true;
        }
        else if (slot2 == null)
        {
            slot2 = flower;
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

        Instantiate(Phase2LevelManager.instance.PotionPrefab).GetComponent<Potion>().Set(slot1,slot2);
        slot1 = slot2 = null;
        return new Potion();

    }

    [ContextMenu("Cancel")]
    public void Cancel()
    {

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
