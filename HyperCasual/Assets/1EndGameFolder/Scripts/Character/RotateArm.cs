using UnityEngine;

public class RotateArm : MonoBehaviour
{
    public Joystick Joystick;
    public float speed = 10f;

    Transform armPosition;
    float rotateZ;
    
    void Start()
    {
        armPosition = transform;
    }

    void Update()
    {
        ArmRotate();
    }

    void ArmRotate()
    {
        if (Joystick.Vertical != 0 && Joystick.Horizontal != 0)
        {
            rotateZ = Mathf.Atan2(Joystick.Vertical, Joystick.Horizontal) * Mathf.Rad2Deg;
            armPosition.rotation = Quaternion.Euler(0, 0, rotateZ + 90);
        }
    }
}
