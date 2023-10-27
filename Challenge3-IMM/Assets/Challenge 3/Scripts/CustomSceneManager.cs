using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{
    public void LoadChallenge3()
    {
        SceneManager.LoadScene("Challenge 3");
    }
     public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ExitScene()
    {
        Application.OpenURL("https://github.com/NicolaeCasian/Challenge3-IMM");
    }
}
