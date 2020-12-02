using UnityEngine;
using UnityEngine.Events;

public class RingEvent : MonoBehaviour
{
    [SerializeField]
    UnityEvent<int> OnPointsChange;

    public void ChangePoints(int points)
    {
        OnPointsChange.Invoke(points);
    }
}
