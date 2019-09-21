using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem : MonoBehaviour
{
    public string Name { get; } = "TestItem";

    [SerializeField]
    private FlowerColor _Color = FlowerColor.red;
    public FlowerColor Color { get { return FlowerColor.red; } }

    [SerializeField]
    private Sprite _Image;
    public Sprite Image { get { return _Image; } }

    public void OnPickup()
    {
        Destroy(gameObject);
    }

    [ContextMenu("SPEED!!!")]
    public void SPEED()
    {
        //PotionEffects.Invoke(PotionEffect.multiplication);
        Potion potion = Instantiate(GameManager.PotionPrefab).GetComponent<Potion>();
        potion.Set((PotionColor)counter);
        potion.gameObject.SetActive(false);
        GameManager.Inventory.AddPotion(potion);
        counter++;
        if (counter > 14)
            counter = 0;
    }
    int counter = 0;


    private void OnMouseDown()
    {
        SPEED();
    }
}
