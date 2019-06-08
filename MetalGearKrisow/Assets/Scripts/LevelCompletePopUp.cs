using UnityEngine;
using UnityEngine.UI;

public class LevelCompletePopUp : MonoBehaviour
{
    public static bool IsLevelCompleted = false;
    private LevelsManager levelsManager;
    private string nextLevelName;

    public GameObject popUpUI;

    void Start()
    {
        popUpUI.SetActive(false);
        levelsManager = GameObject.Find("Manager").GetComponent<LevelsManager>();
    }

    public void GoToNextLevel(string nextLevelName)
    {
        this.nextLevelName = nextLevelName;
        transform.Find("LevelCompleteInfo").GetComponent<Text>().text = GameObject.Find("Manager").GetComponent<CounterController>().GetInfo();
        GameObject.Find("Girl").GetComponent<PlayerController>().Disable();
        popUpUI.SetActive(true);
    }

    public void NextLevel()
    {
        levelsManager.NextLevel(nextLevelName);
        GameObject.Find("Girl").GetComponent<PlayerController>().Enable();
        popUpUI.SetActive(false);
    }
}
