using System.Collections;
using UnityEngine;

public class BallLifeTime : MonoBehaviour
{
    public float LifeTime = 5f;
    private void Start()
    {
        StartCoroutine(CheckLifeTime());
    }
    IEnumerator CheckLifeTime()
    {
        yield return new WaitForSeconds(LifeTime);
        BallDestroyer.DestroyBall(gameObject);
    }
}
