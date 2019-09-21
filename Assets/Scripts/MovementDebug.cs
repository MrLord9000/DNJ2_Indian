using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementDebug : MonoBehaviour
{
#pragma warning disable
    [SerializeField] private TextMeshProUGUI text;
#pragma warning restore

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        text.text = "Velocity x: " + rb.velocity.x + "\n" +
                    "Velocity y: " + rb.velocity.y + "\n";
    }
}
