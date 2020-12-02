using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class ImpulseCreator : MonoBehaviour
{
    public float ImpulsePower = 12f;
    [Range(1f, 10f)]
    public float EnemyVelocitySlower = 5f;

    protected Rigidbody2D body;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            SetImpulse(other);
        }
    }
    virtual protected void SetImpulse(Collision2D other)
    {
        body = other.gameObject.GetComponent<Rigidbody2D>();
        body.velocity = -body.velocity / EnemyVelocitySlower;
        body.AddForce((other.transform.position - transform.position) * ImpulsePower, ForceMode2D.Impulse);
    }
}