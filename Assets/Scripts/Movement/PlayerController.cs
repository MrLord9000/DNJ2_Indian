using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
#pragma warning disable
    public float speed = 1f;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer indicator;
#pragma warning restore

    private PlayerInput playerInput;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Flower item;

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
            GameManager.Inventory.AddFlower(item);
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
        item = collision.GetComponent<Flower>();
        indicator.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Flower>() == item)
        {
            item = null;
        }
        indicator.enabled = false;
    }

    private void Update()
    {
        rb.AddForce(movement * speed);

        if (rb.velocity.x > .05f || rb.velocity.y < -.05f)
        {
            animator.Play("Player_walk_front");
        }
        else if (rb.velocity.x < -.05f || rb.velocity.y > .05f)
        {
            animator.Play("Player_walk_back");
        }
        else
        {
            animator.Play("Player_idle");
        }

    }
}
