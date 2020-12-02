using UnityEngine;

public class RingChecker : MonoBehaviour
{
    public int pointValue = 1;

    GameObject parent;

    private void Start()
    {
        parent = transform.parent.gameObject;
        pointValue = parent.GetComponent<BallValue>().PointValue;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out RingEvent ring))
        {
            ring.ChangePoints(pointValue);

            Destroy(parent);
        }
    }
}