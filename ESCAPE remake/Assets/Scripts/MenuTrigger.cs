using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTrigger : MonoBehaviour
{
    public AudioClip Collect;
    public AudioSource CollectSound;

    void Start()
    {
        CollectSound.clip = Collect;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            CollectSound.Play();
        }
    }
}
