using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D), typeof(SpriteRenderer))]
public class Flower2 : MonoBehaviour
{

    new private BoxCollider2D collider;
    private Vector3 pos;
    [SerializeField] FlowerColor color;

    public FlowerColor Color
    {
        get => color;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnMouseDown()
    {
        if (GameManager.Instance.areFlowersDraggable)
        {
            pos = transform.position;
        }
    }

    private void OnMouseUp()
    {
        List<Collider2D> contacts = new List<Collider2D>();
        collider.OverlapCollider(new ContactFilter2D(), contacts);

        foreach (Collider2D contatc in contacts)
        {
            GameObject obj = contatc?.gameObject;
            if (obj?.GetComponent<ThePot>()?.AddFlower(this) ?? false)
            {
                //transform.position = obj.transform.position;
                transform.position = pos;
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
    */
}
