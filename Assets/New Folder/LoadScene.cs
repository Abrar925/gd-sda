using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        Debug.Log("MenuButton");

        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
