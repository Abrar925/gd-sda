using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void LoadLevel1()
    {
        Loadinglndicator.Instance.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        Loadinglndicator.Instance.LoadScene("Level2");
    }

}
