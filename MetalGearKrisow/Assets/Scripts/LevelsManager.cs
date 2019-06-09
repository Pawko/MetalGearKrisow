using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{
    public PlayerController playerController;
    private string currentLevelName;

    void Start()
    {
        currentLevelName = SceneManager.GetActiveScene().name;
    }

    public void NextLevel(string levelName)
    {
        currentLevelName = levelName;
        SceneManager.LoadScene(levelName);
    }
    
    public void RestartLevel()
    {
        NextLevel(currentLevelName);
    }
}
