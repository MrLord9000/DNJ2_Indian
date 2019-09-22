using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(SpriteRenderer),typeof(Collider2D))]
public class Corner : MonoBehaviour
{
    public FlowerColor color;
    private SpriteRenderer sRenderer;
    private Collider2D collider2D;
    private List<Flower2> ingridients = new List<Flower2>(); 

    private void Awake()
    {
        ingridients = GetComponentsInChildren<Flower2>().ToList();
        Debug.Log(color + " - " + ingridients.Count);
        collider2D = GetComponent<Collider2D>();
        sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.color = color.GetColor();
        sRenderer.enabled = false;
    }

    public void TurnOn() => sRenderer.enabled = true;

    public void TurnOff() => sRenderer.enabled = false;

    public void Refresh()
    {
        int number = GameManager.Inventory.flowers[color];
        Debug.Log(color + ": " + number + " - " + ingridients.Count);
        for (int i = 0; i < number; i++)
        {
            ingridients[i].gameObject.SetActive(true);
        }
        for (int i = number; i < ingridients.Count; i++)
        {
            ingridients[i].gameObject.SetActive(false);
        }
    }

}
