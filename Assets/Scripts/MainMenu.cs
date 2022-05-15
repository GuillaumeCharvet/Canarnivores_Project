using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource truc;

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene 1");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
