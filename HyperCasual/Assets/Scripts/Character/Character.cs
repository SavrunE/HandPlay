using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class Character : MonoBehaviour
{
    public Joystick Joystick;

    [SerializeField] private float moveSpeed = 350f;

    bool lookOnLeft = true;

    Animator animator;
    Rigidbody2D body;
    Transform head;
    Vector2 moveVelocity;

    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        head = transform.Find("Face");
    }
    void FixedUpdate()
    {
        Move();
        if (lookOnLeft == true && body.velocity.x > 0)
            FlipHead();
        else if (lookOnLeft == false && body.velocity.x < 0)
            FlipHead();
    }
    void Move()
    {
        moveVelocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime, body.velocity.y);
        body.velocity = moveVelocity;
        //body.velocity = new Vector2(Joystick.Horizontal * moveSpeed * Time.fixedDeltaTime, body.velocity.y);
        MoveAnimation();
    }
    void FlipHead()
    {
        lookOnLeft = !lookOnLeft;
        Vector3 Scaler = head.localScale;
        Scaler.x *= -1;
        head.localScale = Scaler;
    }
    void MoveAnimation()
    {
        if (moveVelocity.x != 0)
            animator.SetBool("IsMoving", true);
        else
            animator.SetBool("IsMoving", false);
    }
}
