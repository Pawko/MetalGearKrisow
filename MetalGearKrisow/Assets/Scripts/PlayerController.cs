using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed;
    public float PlayerJumpForce;

    private Animator Animator;
    private Rigidbody2D Rigidbody2D;
    private bool IsDirectionToRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        Rigidbody2D.velocity = new Vector2(horizontalMove * PlayerSpeed, Rigidbody2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
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
}
