using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorButton : MonoBehaviour
{
    private GameObject raycastedObj;
    public LayerMask layerMaskInteract;
    public float range = 4f;
    public GameManager gameManager;

    void Update()
    {
        RaycastHit hitt;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hitt, range, layerMaskInteract.value))
        {
            if (hitt.collider.CompareTag("Button"))
            {
                raycastedObj = hitt.collider.gameObject;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    gameManager.openDoor();
                    gameManager.disableButton();
                }
            }
        }
    }

   
}
