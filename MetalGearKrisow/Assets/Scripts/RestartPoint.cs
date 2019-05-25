using UnityEngine;

public class RestartPoint : MonoBehaviour
{
    private RestartPointsManager restartPointsManager;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        restartPointsManager = GameObject.Find("Manager").GetComponent<RestartPointsManager>();
        if (restartPointsManager == null)
        {
            Debug.LogError("RestartPointsManager is null.");
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            restartPointsManager.UpdateStartPoint(this.gameObject.transform);
            spriteRenderer.color = new Color(0.3f, 0.8f, 0.6f);
            this.GetComponent<Collider2D>().enabled = false;
        }

    }
}
