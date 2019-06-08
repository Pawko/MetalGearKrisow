using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{

    public PlayerController playerController;

    void Start()
    {
        
    }

    public void NextLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
