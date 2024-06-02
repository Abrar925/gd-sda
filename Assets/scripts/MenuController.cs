using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("ggg");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
