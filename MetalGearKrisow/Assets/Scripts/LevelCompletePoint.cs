using UnityEngine;

public class LevelCompletePoint : MonoBehaviour
{
    private LevelsManager levelsManager;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        levelsManager = GameObject.Find("LevelsManager").GetComponent<LevelsManager>();
        if (levelsManager == null)
        {
            Debug.LogError("LevelsManager is null.");
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            levelsManager.NextLevel();
            this.GetComponent<Collider2D>().enabled = false;
        }

    }
}
