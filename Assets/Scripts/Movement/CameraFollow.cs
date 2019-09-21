using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour
{
#pragma warning disable
    [SerializeField] private Transform objectToTrack;
    [SerializeField] private float accuracy = .1f;
    [SerializeField] private float speed = .5f;
    [SerializeField] private bool snapToInt = false;
#pragma warning restore

    private void FixedUpdate()
    {
        if(objectToTrack != null && !IsBetween(transform.position, objectToTrack.position, accuracy))
        {
            transform.position = Vector3.Slerp(transform.position, 
                new Vector3(objectToTrack.position.x, objectToTrack.position.y, transform.position.z), 
                speed * Vector2.Distance(transform.position, objectToTrack.position));
        }
    }

    private bool IsBetween(Vector2 position, Vector2 destination, float accuracy)
    {
        if(position.x > destination.x - accuracy && position.x < destination.x + accuracy && position.y > destination.y - accuracy && position.y < destination.y + accuracy)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
