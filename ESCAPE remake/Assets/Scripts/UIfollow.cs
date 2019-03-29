using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIfollow : MonoBehaviour
{
    public Camera fpsCam;

    void Update()
    {
        transform.LookAt(transform.position + fpsCam.transform.rotation * -Vector3.back, fpsCam.transform.rotation * Vector3.up);
    }
}
