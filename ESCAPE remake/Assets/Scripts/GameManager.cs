using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioClip opening;
    public AudioSource buttonSound;

    public Animator platform1;
    public Animator platform2;
    public Animator platform3;
    public GameObject fpsCam;
    public Animator leftDoor;
    public Animator rightDoor;
    public GameObject LevelComplete;
    public Light platform_1;
    public Light platform_2;
    public Light platform_3;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject BPWspots;
    public GameObject fadeIn;

    void Start()
    {
        disableButton();
        disableButton2();
        buttonSound.clip = opening;
        leftDoor.enabled = false;
        rightDoor.enabled = false;

        platform1.enabled = false;
        platform2.enabled = false;
        platform3.enabled = false;

        platform_1 = light1.GetComponent<Light>();
        platform_2 = light2.GetComponent<Light>();
        platform_3 = light3.GetComponent<Light>();

        BPWspots.SetActive(false);

        fadeIn.SetActive(true);
    }

    private void Update()
    {
        if (ScoreScript.scoreValue > 4 && ScoreScript.scoreValue < 6)
        {
            spotsOn();
        }
    }

    public void disableButton()
    {
        fpsCam.GetComponent<doorButton>().enabled = false;
    }

    public void disableButton2()
    {
        fpsCam.GetComponent<OpenCage>().enabled = false;
    }

    public void enableButton()
    {
        fpsCam.GetComponent<doorButton>().enabled = true;
    }

    public void enableButton2()
    {
        fpsCam.GetComponent<OpenCage>().enabled = true;
    }

    public void openDoor()
    {
        buttonSound.PlayOneShot(opening);
        leftDoor.enabled = true;
        rightDoor.enabled = true;
    }

    public void movePlatforms()
    {
        {
            platform1.enabled = true;
            platform_1.enabled = true;
            platform2.enabled = true;
            platform_2.enabled = true;
            platform3.enabled = true;
            platform_3.enabled = true;
        }
    }

    public void EndGame()
    {
        LevelComplete.SetActive(true);
    }

    public void spotsOn()
    {
        BPWspots.SetActive(true);
    }
}
