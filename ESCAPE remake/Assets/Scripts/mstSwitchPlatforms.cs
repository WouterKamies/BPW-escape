using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mstSwitchPlatforms : MonoBehaviour
{
    public Material on2;
    public Material off2;
    public GameManager gameManager;

    private void Start()
    {
        GetComponent<Renderer>().material = off2;
    }

    public void matSwitch2()
    {
        GetComponent<Renderer>().material = on2;
    }

    private void Update()
    {
        if (ScoreScript.scoreValue == 1)
        {
            matSwitch2();
            gameManager.movePlatforms();
            gameManager.enableButton2();

        }
    }
}
