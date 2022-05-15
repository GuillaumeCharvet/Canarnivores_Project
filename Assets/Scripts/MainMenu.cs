using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene 1");
    }

    public void CreditButton()
    {

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
