using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
#pragma warning disable
    public float speed = 1f;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer indicator;
    public bool hasControl = true;
#pragma warning restore

    private PlayerInput playerInput;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Flower item;

    private AudioSource source;
    public List<AudioClip> dirtStepSounds = new List<AudioClip>();
    public AudioClip pickingFlower;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        if (hasControl)
        {
            movement = context.ReadValue<Vector2>();
        }
        else
        {
            movement.Set(0, 0);
        }
    }

    public void OnAction()
    {
        if (item != null)
        {
            animator.SetTrigger("ItemPick");
            GameManager.Inventory.AddFlower(item);
            //Debug.Log("<color=green>Picked up " + item + "</color>");
            item = null;
            if(source.clip!=pickingFlower||(!source.isPlaying)){
                source.clip=pickingFlower;
                source.volume=0.25f;
                source.Play();
            }
        }
            
        else
        {
            Debug.Log("<color=blue>No item in range!</color>");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        item = collision.GetComponent<Flower>();
        item.Highlight();
        //indicator.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Flower>() == item)
        {
            item.Unhighlight();
            item = null;
        }
        //indicator.enabled = false;
    }

    private void Update()
    {
        rb.AddForce(movement * speed);

        if (rb.velocity.x > .05f || rb.velocity.y < -.05f)
        {
            animator.Play("Player_walk_front");
            if (!source.isPlaying){
                source.clip=dirtStepSounds[Random.Range(0,dirtStepSounds.Count)];
                source.volume=1f;
                source.Play();
            }
            
        }
        else if (rb.velocity.x < -.05f || rb.velocity.y > .05f)
        {
            animator.Play("Player_walk_back");
            if (!source.isPlaying){
                source.clip=dirtStepSounds[Random.Range(0,dirtStepSounds.Count)];
                source.volume=1f;
                source.Play();
            }
        }
        else
        {
            //animator.Play("Player_idle");
        }

    }
}
