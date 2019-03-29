using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleTrigger : MonoBehaviour
{
    public AudioClip Collect;
    public AudioClip Boom;
    public AudioSource CollectSound;
    public AudioSource BoomSound;
    public GameManager gameManager;

    void Start()
    {
        CollectSound.clip = Collect;
        BoomSound.clip = Boom;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            CollectSound.Play();
            ScoreScript.scoreValue += 1;
            if (ScoreScript.scoreValue == 5)
            {
                CollectSound.PlayOneShot(Collect);
                BoomSound.Play();
                gameManager.enableButton();

            }
        }
    }

}