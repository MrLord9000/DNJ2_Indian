using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem : MonoBehaviour, IInventoryItem
{
    public string Name { get; } = "TestItem";

    [SerializeField]
    private Color _Color = Color.red;
    public Color Color { get { return _Color; } }

    [SerializeField]
    private Sprite _Image;
    public Sprite Image { get { return _Image; } }

    public void OnPickup()
    {
        Destroy(gameObject);
    }
}
