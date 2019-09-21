using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem : MonoBehaviour, IInventoryItem
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
        PotionEffects.Invoke(PotionEffect.multiplication);
    }

    private void OnMouseDown()
    {
        SPEED();
    }
}
