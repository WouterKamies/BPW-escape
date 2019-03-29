using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour
{
    GameObject mainCamera;
    bool carrying;
    GameObject carriedObject;
    public float distance;
    public float range;
    public float smooth;
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    void Update()
    {
        if (carrying)
        {
            carry(carriedObject);
            checkDrop();
        }
        else
        {
            pickup();
        }
    }

    void rotateObject()
    {
        carriedObject.transform.Rotate(5, 10, 15);
    }

    void carry(GameObject o)
    {
        o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
    }

    void pickup()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, range))
            {
                Pickupable p = hit.collider.GetComponent<Pickupable>();
                if (p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    p.gameObject.GetComponent<Rigidbody>().useGravity = false;
                }
            }
            else if(hit.collider.CompareTag("Button"))
            {
                Debug.Log("Door open");
            }
        }
        
    }

    void checkDrop()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
        carriedObject = null;
    }
}