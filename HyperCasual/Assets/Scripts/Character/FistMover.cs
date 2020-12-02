using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistMover : MonoBehaviour
{
    public Transform FistPosition;
    [Range(0.1f,1f)]
    public float Speed;
    private void Start()
    {
        Physics2D.IgnoreLayerCollision(gameObject.layer, 6);//Player
        Physics2D.IgnoreLayerCollision(gameObject.layer, 7);//Wall
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, FistPosition.position, Speed);
    }
}
