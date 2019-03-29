using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNextScene : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject fadeIn;
    public AudioClip MenuClick;
    public AudioSource MenuSource;

    void Start()
    {
        MenuSource.clip = MenuClick;
        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void startPress()
    {
        fadeOut.SetActive(true);
    }

    public void menuClick()
    {
        MenuSource.Play();
    }
}
