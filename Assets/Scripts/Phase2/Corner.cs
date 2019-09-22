using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer),typeof(Collider2D))]
public class Corner : MonoBehaviour
{
    public FlowerColor color;
    private SpriteRenderer sRenderer;
    private Collider2D collider2D;

    private void Awake()
    {
        collider2D = GetComponent<Collider2D>();
        sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.color = color.GetColor();
        sRenderer.enabled = false;
    }

    public void TurnOn() => sRenderer.enabled = true;

    public void TurnOff() => sRenderer.enabled = false;

}
