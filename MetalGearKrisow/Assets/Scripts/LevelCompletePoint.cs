using UnityEngine;

public class LevelCompletePoint : MonoBehaviour
{
    private LevelsManager levelsManager;
    private SpriteRenderer spriteRenderer;
    public string levelName;

    void Start()
    {
        levelsManager = GameObject.Find("Manager").GetComponent<LevelsManager>();
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
            levelsManager.NextLevel(levelName);
            this.GetComponent<Collider2D>().enabled = false;
        }

    }
}
