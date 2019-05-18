using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Transform navigationStartPoint;
    public Transform navigationEndPoint;

    private Vector2 startPoint;
    private Vector2 endPoint;
    private Vector2 currentPlatformPosition;

    void Start()
    {
        startPoint = navigationStartPoint.position;
        endPoint = navigationEndPoint.position;
        Destroy(navigationStartPoint.gameObject);
        Destroy(navigationEndPoint.gameObject);
    }

    void Update()
    {
        currentPlatformPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlatformPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = transform;
            other.attachedRigidbody.Sleep();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        { 
            other.transform.parent = null;
        }
    }
}

