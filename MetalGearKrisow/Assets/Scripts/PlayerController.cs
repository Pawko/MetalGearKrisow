using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed;
    public float PlayerJumpForce;
    public Transform GroundDetector;
    public LayerMask LayerMask;

    private Animator Animator;
    private Rigidbody2D Rigidbody2D;
    private bool IsDirectionToRight = true;
    private bool IsOnTheGround;
    private float Radius = 0.1f;
    public Transform startPoint;


    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        IsOnTheGround = Physics2D.OverlapCircle(GroundDetector.position, Radius, LayerMask);
        float horizontalMove = Input.GetAxis("Horizontal");
        Rigidbody2D.velocity = new Vector2(horizontalMove * PlayerSpeed, Rigidbody2D.velocity.y);

        if (IsOnTheGround && Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D.AddForce(new Vector2(0, PlayerJumpForce));
            Animator.SetTrigger("jump");
        }

        Animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (horizontalMove < 0 && IsDirectionToRight) // Left Arrow was clicked
        {
            Flip();
        }
        if (horizontalMove > 0 && !IsDirectionToRight) // Right Arrow was clicked
        {
            Flip();
        }        
    }

    private void Flip()
    {
        IsDirectionToRight = !IsDirectionToRight;
        Vector3 playerScale = gameObject.transform.localScale;
        playerScale.x *= -1;
        gameObject.transform.localScale = playerScale;
    }

    public void RestartPlayer()
    {
        gameObject.transform.position = startPoint.position;
    }
}
