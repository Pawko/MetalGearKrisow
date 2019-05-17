using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public Transform cameraTransform;
    public float parallaxFactor;

    private Vector3 previousCameraPosition;
    private Vector3 deltaCameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        previousCameraPosition = cameraTransform.position;

    }

    // Update is called once per frame
    void Update()
    {
        deltaCameraPosition = cameraTransform.position - previousCameraPosition;
        Vector3 parallaxPosition = new Vector3(
            x: transform.position.x + (deltaCameraPosition.x * parallaxFactor), 
            y: transform.position.y, 
            z: transform.position.z
        );
        transform.position = parallaxPosition;
        previousCameraPosition = cameraTransform.position;
    }
}
