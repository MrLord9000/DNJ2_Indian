using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
#pragma warning disable
    public float speed = 1f;
    [SerializeField] Inventory inventory;
#pragma warning restore

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IInventoryItem item = collision.GetComponent<IInventoryItem>();
        if (item != null)
        {
            inventory.AddItem(item);
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.up.normalized * speed);
        }
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.down.normalized * speed);
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.left.normalized * speed);
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.right.normalized * speed);
        }
    }
}
