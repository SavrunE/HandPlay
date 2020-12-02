using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWallChecker : MonoBehaviour
{
    public int CollisionToDestroy = 5;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Wall>(out Wall wall))
        {
            CollisionToDestroy--;
            if (CollisionToDestroy <= 0)
            {
                BallDestroyer.DestroyBall(gameObject);
            }
        }
    }
}
