using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialSwitch : MonoBehaviour
{
    public Material off;
    public Material on;
    public GameManager gameManager;

    private void Start()
    {
        GetComponent<Renderer>().material = off;
    }

    public void matSwitch()
    {
        GetComponent<Renderer>().material = on;
    }

    private void Update()
    {
        if (ScoreScript.scoreValue == 5)
        {
            matSwitch();
        }
    }
}
