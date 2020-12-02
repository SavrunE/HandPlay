using UnityEngine;
using UnityEngine.Events;

public class BallDestroyer : MonoBehaviour
{
    public static UnityEvent m_MyEvent;

    public static void DestroyBall(GameObject gameObject)
    {
        m_MyEvent?.Invoke();
        Destroy(gameObject);
    }
}
