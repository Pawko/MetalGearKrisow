using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailCactusController : MonoBehaviour
{
    public Transform startPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            other.transform.position = startPoint.position;
        }
    }
}
