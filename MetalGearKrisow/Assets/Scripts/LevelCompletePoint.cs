using UnityEngine;

public class LevelCompletePoint : MonoBehaviour
{
    public LevelCompletePopUp levelCompletePopUp;
    public string levelName;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            levelCompletePopUp.GoToNextLevel(levelName);
            this.GetComponent<Collider2D>().enabled = false;
        }
    }
}
