using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBoxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            Destroy(this.gameObject);
        }
    }
}
