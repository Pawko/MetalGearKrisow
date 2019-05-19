using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailCactusController : MonoBehaviour
{

    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
