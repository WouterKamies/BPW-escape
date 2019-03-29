using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelComplete : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.EndGame();
            //play sound effect;
            Debug.Log("Won");
        }
    }
}
