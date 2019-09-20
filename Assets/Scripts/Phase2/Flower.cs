using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Flower : MonoBehaviour
{

    new private BoxCollider2D collider;
    private Vector3 pos;
    [SerializeField] FlowerColor color;


    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //TYMCZASOWE
        GetComponent<SpriteRenderer>().color = color.GetColor();
    }


    private void OnMouseDown()
    {
        pos = transform.position;
    }

    private void OnMouseUp()
    {
        List<Collider2D> contacts = new List<Collider2D>();
        Debug.Log( collider.OverlapCollider( new ContactFilter2D(), contacts ) );
       
        foreach( Collider2D contatc in contacts )
        {
            GameObject obj = contatc?.gameObject;
            if ( obj?.GetComponent<FlowerSlot>() != null )
            {
                transform.position = obj.transform.position;
                return;
            }
        }
        transform.position = pos;
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position -= transform.position.z * Vector3.forward;
    }
}

public enum FlowerColor
{
    red,
    green,
    blue
}

public static class FlowerColorExtension
{
    public static Color GetColor(this FlowerColor fc)
    {
        switch (fc)
        {
            case FlowerColor.red:
                return Color.red;
            case FlowerColor.green:
                return Color.green;
            case FlowerColor.blue:
                return Color.blue;
            default:
                return Color.clear;
        }
    }
}