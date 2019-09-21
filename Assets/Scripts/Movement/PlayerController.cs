using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
#pragma warning disable
    public float speed = 1f;
    [SerializeField] Inventory inventory;
#pragma warning restore

    private PlayerInput playerInput;
    private Rigidbody2D rb;
    private Vector2 movement;
    private IInventoryItem item;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnAction()
    {
        if (item != null)
        {
            inventory.AddFlower(item);
            Debug.Log("<color=green>Picked up " + item + "</color>");
            item = null;
        }
        else
        {
            Debug.Log("<color=blue>No item in range!</color>");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        item = collision.GetComponent<IInventoryItem>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<IInventoryItem>() == item)
        {
            item = null;
        }
    }

    private void Update()
    {
        rb.AddForce(movement * speed);
    }
}
