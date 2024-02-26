using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void LoadLevel1()
    {
        LoadingIndicator.Instance.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        LoadingIndicator.Instance.LoadScene("Level2");
    }

}
