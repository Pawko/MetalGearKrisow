using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //The target player
    public Transform player;
    //At what distance will the enemy walk towards the player?
    public float walkingDistance = 10.0f;
    //In what time will the enemy complete the journey between its position and the players position
    public float smoothTime = 10.0f;
    //Vector3 used to store the velocity of the enemy
    private Vector3 smoothVelocity = Vector3.zero;
    Animator animator;
    bool IsDirectionToRight = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Flip()
    {
        IsDirectionToRight = !IsDirectionToRight;
        Vector3 playerScale = gameObject.transform.localScale;
        playerScale.x *= -1;
        gameObject.transform.localScale = playerScale;
    }
    //Call every frame
    void Update()
    {
        animator.SetInteger("AnimState", 0);
        if (Vector3.Distance(transform.position, player.position) > 1f)
        {
            //Flip();
        }

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < walkingDistance && distance > 1.3f)
        {
            animator.SetInteger("AnimState", 2);
            //Move the enemy towards the player with smoothdamp
            //transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
            transform.position = Vector3.MoveTowards(transform.position, player.position, smoothTime * Time.deltaTime);
        }
        if (distance < 1.3f)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("LightGuard_Attack"))
                return;
            animator.SetTrigger("Attack");

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
            //AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
