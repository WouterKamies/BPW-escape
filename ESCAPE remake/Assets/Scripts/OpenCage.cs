using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCage : MonoBehaviour
{
    public GameObject cageBars;
    public Collider colliderWall;
    private GameObject raycastedObj;
    public GameObject button2;
    public LayerMask layerMaskInteract;
    public float range = 4f;
    public GameManager gameManager;
    public Text locked;
    public Text unlocked;
 
    public AudioClip unlocking;
    public AudioSource buttonUnlock;

    public Material off;

    private void Start()
    {
        buttonUnlock.clip = unlocking;
    }

    void Update()
    {
        RaycastHit hitt;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hitt, range, layerMaskInteract.value))
        {
            if (hitt.collider.CompareTag("Button_2"))
            {
                raycastedObj = hitt.collider.gameObject;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    button2.GetComponent<Renderer>().material = off;
                    
                    colliderWall.enabled = false;
                    cageBars.GetComponent<Renderer>().enabled = false;
                    locked.enabled = false;
                    unlocked.enabled = true;
                    gameManager.disableButton2();
                    buttonUnlock.PlayOneShot(unlocking);
                }
            }
        }
    }
}
