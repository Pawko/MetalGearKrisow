using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    public int totalNumberOfBoxes;
    public Text counterView;
    private int numberOfBoxes;

    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();
    }

    public void IncrementCounter()
    {
        numberOfBoxes++;
        counterView.text = $"{numberOfBoxes} / {totalNumberOfBoxes}";
    }

    public void ResetCounter()
    {
        numberOfBoxes = 0;
        counterView.text = $"{numberOfBoxes} / {totalNumberOfBoxes}";
    }

    public string GetInfo()
    {
        return $"You collected {numberOfBoxes} / {totalNumberOfBoxes} boxes";
    }
}
