using UnityEngine;

public class RemoveEclipseForTime : MonoBehaviour
{
    public float ElipceRecovery;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        Color color = spriteRenderer.color;
        if (color.a != 0)
        {
            color.a -= ElipceRecovery;
            if (color.a < 0)
                color.a = 0;
            spriteRenderer.color = color;
        }
    }
}