using UnityEngine;

public class FaceTrader : ImpulseCreator
{
    [Header("Elipse changer settings")]
    [SerializeField] SpriteRenderer eclipseSprite;
    [Range(1f, 100f)]
    [SerializeField] float maxMagnitude;
    [SerializeField] float overloadMagnitude;
    protected override void SetImpulse(Collision2D other)
    {
        base.SetImpulse(other);
        ColorChanger();
    }
    void ColorChanger()
    {
        float magnitude = body.velocity.magnitude * overloadMagnitude;
        float changeAlpha = magnitude > maxMagnitude ? maxMagnitude : magnitude;

        Color color = eclipseSprite.color;

        color.a += changeAlpha / 100;
        eclipseSprite.color = color;
    }
}