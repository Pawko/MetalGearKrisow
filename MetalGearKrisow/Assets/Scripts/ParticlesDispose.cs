using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesDispose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Dispose", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dispose()
    {
        Destroy(gameObject);
    }
}
