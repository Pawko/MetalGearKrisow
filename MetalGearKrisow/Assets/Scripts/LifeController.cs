using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    public int NumberOfLives;
    public Text lifeView;
    private int remainingNumberOfLives;

    public GameObject GameOverPopUpUI;

    void Start()
    {
        HideGameOverPopUp();
        ResetLives();
    }

    public void ShowGameOverPopUp()
    {
        GameOverPopUpUI.SetActive(true);
    }

    public void HideGameOverPopUp()
    {
        GameOverPopUpUI.SetActive(false);
    }

    public bool IsAnyLifeLeft()
    {
        return remainingNumberOfLives > 0;
    }

    public void ResetLives()
    {
        remainingNumberOfLives = NumberOfLives;
        UpdateLifeView();
    }

    public bool DecrementLife()
    {
        if (remainingNumberOfLives <= 0) return false;

        remainingNumberOfLives--;
        UpdateLifeView();

        return IsAnyLifeLeft();
    }

    public void UpdateLifeView()
    {
        if (lifeView != null)
            lifeView.text = $"Lives: {remainingNumberOfLives}";
    }

    public void RestartLevel()
    {
        var levelsManager = GameObject.Find("Manager").GetComponent<LevelsManager>();
        levelsManager.RestartLevel();
    }
}
