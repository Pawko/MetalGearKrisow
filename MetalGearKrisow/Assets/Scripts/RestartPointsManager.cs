using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPointsManager : MonoBehaviour
{
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateStartPoint(Transform restartPoint)
    {
        playerController.startPoint = restartPoint;
    }
}
