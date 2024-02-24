using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineDemo : MonoBehaviour
{
    private Coroutine m_coroutine;

    // Start is called before the first frame update
    void Start()
    {
        m_coroutine = StartCoroutine(MyCoroutine(3.0f));
    }

    public void Cancel()
    {
        StopCoroutine(m_coroutine);
    }

    private IEnumerator MyCoroutine(float time)
    {
        int counter = 0;
        while (true)
        {
            Debug.Log("Hello" + counter.ToString());
            yield return new WaitForSeconds(time);
            ++counter;
        }

    }
}
