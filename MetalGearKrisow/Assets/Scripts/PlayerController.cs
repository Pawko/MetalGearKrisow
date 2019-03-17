using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator Animator;
    
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        Animator.SetFloat("speed", Mathf.Abs(horizontalMove));
    }
}
