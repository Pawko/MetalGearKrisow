using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBoxController : MonoBehaviour
{
    CounterController counterController;
    public AudioClip clip;
    public GameObject particlesPrefab;

    private bool isCurrentlyTriggered;
    // Start is called before the first frame update
    void Start()
    {
        isCurrentlyTriggered = false;
        counterController = GameObject.Find("Manager").GetComponent<CounterController>();
        if (counterController == null)
            Debug.LogError("CounterController is null");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isCurrentlyTriggered && other.gameObject.tag == "Player")
        {
            isCurrentlyTriggered = true;
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            counterController.IncrementCounter();
            Instantiate(particlesPrefab, transform.position, transform.rotation);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isCurrentlyTriggered = false;
        }
    }
}
